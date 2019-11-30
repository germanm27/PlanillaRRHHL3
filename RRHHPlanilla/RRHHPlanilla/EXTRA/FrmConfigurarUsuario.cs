using RRHH.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace RRHHPlanilla
{
    public partial class FrmConfirmarConf : Form
    {
        SeguridadBL _seguridad;
        PrivilegiosBL _privilegios;

        public FrmConfirmarConf()
        {
            InitializeComponent();
            _seguridad = new SeguridadBL();
            listaSeguridadBindingSource.DataSource = _seguridad.ObtenerUsuario();

            _privilegios = new PrivilegiosBL();
            listaPrivilegiosBindingSource.DataSource = _privilegios.ObtenerPrivilegios();
        }

        //VALIDACION DE CORREO
        private Boolean ValidarEmail(String email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FrmConfirmarConf_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        #endregion


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que dese salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                //UsuarioAutenticado = Cancelar;
                this.Close();
            }

            if (result == DialogResult.No)
            {
                
            }
        }



        private void FrmConfirmarConf_Load(object sender, EventArgs e)
        {
            listaSeguridadBindingNavigatorSaveItem.Enabled = true;
            lblcamb.Visible = false;

        }
            
           
                

        // DESHABILITACION
        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;
            //bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            //toolStripCancelar.Visible = !valor;
        }

        //GUARDAR
        private void listaSeguridadBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            if (ValidarEmail(correoTextBox.Text))
            {
                if (txtnueva.Text != txtconfirmar.Text && contrasenaTextBox.ReadOnly == true
                || contrasenaTextBox.Text != txtconfirmar.Text
                && contrasenaTextBox.ReadOnly == false)
                {
                    DialogResult resul = MessageBox.Show("Las contraseñas no coinciden", " ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                else
                {
                    if (txtconfirmar.Text.Length <= 6 && contrasenaTextBox.ReadOnly == true
                        || contrasenaTextBox.Text.Length <= 6 && contrasenaTextBox.ReadOnly == false)
                    {
                        DialogResult resul = MessageBox.Show(" LA CONTRASEÑA TIENE QUE SER MAYOR A " + "\n" + " 6 CARACTERES ", "",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        if (txtnueva.Text.Length > 6 && contrasenaTextBox.ReadOnly == true
                            || contrasenaTextBox.Text.Length > 6 && contrasenaTextBox.ReadOnly == false)
                        {
                            if (txtconfirmar.Text != "")
                            {
                                contrasenaTextBox.Text = txtconfirmar.Text;
                            }

                            listaSeguridadBindingSource.EndEdit();
                            var usuario = (Usuario)listaSeguridadBindingSource.Current;

                            if (fotoPictureBox.Image != null)
                            {
                                usuario.Foto = Program.imageToByteArray(fotoPictureBox.Image);
                            }
                            else
                            {
                                usuario.Foto = null;
                            }
                            var resultado = _seguridad.GuardarUsuario(usuario);

                            if (resultado.Exitoso == true)
                            {
                                listaSeguridadBindingSource.ResetBindings(false);
                                DeshabilitarHabilitarBotones(true);
                                DialogResult resul = MessageBox.Show("Usuario Guardado", "Exitoso...!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                                contrasenaTextBox.ReadOnly = true;
                                contrasenaTextBox.BackColor = Color.Silver;

                                nombUsuarioTextBox.Focus();
                                txtnueva.Visible = true;
                                txtconfirmar.Text = "";
                                txtnueva.Text = "";

                                label4.Visible = true;
                                lblcamb.Visible = false;
                                lblcamb1.Visible = false;
                                lblcamb2.Visible = false;
                            }
                            else
                            {
                                MessageBox.Show(resultado.Mensaje);
                            }
                        }
                    }
                }
            }
            else
            {
                DialogResult resul = MessageBox.Show(" FORMATO DE CORREO INCORRECTO ", "",
            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                correoTextBox.SelectAll();
                correoTextBox.Focus();
            }

        }

        #region  BORRAR
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

            if (idTextBox.Text != "")
            {
                DialogResult resulto = MessageBox.Show("¿Desea Eliminar el Registro?", "Eliminar",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resulto == DialogResult.Yes)
                {
                    nombUsuarioTextBox.Focus();
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {
            var resultado = _seguridad.EliminarUsuario(id);

            if (resultado == true)
            {
                listaSeguridadBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar la capacidad");
            }
        }
        #endregion

        #region FOTO
        private void button1_Click(object sender, EventArgs e)
        {
            var usuario = (Usuario)listaSeguridadBindingSource.Current;

            if (usuario != null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var filestream = fileInfo.OpenRead();

                    fotoPictureBox.Image = Image.FromStream(filestream);
                }
            }
            else
            {
                MessageBox.Show("Cree un trabajador antes de asignarle una imagen");
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        #endregion

        //AGREGAR
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            nombUsuarioTextBox.Focus();
            txtnueva.Visible = false;
            label4.Visible = false;
            lblcamb1.Visible = false;

            lblcontrasena.Text = "Contraseña";
            contrasenaTextBox.ReadOnly = false;
            contrasenaTextBox.BackColor = Color.White;

            //txtnueva.ReadOnly = true;
            //txtnueva.BackColor = Color.Silver;
            //txtnueva.Text = "";

            //txtconfirmar.ReadOnly = true;
            //txtconfirmar.BackColor = Color.Silver;
            txtconfirmar.Text = "";


            listaSeguridadBindingNavigatorSaveItem.Enabled = true;
            _seguridad.AgregarUsuario();
            listaSeguridadBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        #region EVENTO MOSTRAR CONTRASEÑA
        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            if (contrasenaTextBox.UseSystemPasswordChar == true)
            {
                contrasenaTextBox.UseSystemPasswordChar = false;
            }
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            if (contrasenaTextBox.UseSystemPasswordChar == false)
            {
                contrasenaTextBox.UseSystemPasswordChar = true;
            }
        }

        #endregion

        #region LABELS LINK
        private void contrasenaTextBox_Leave(object sender, EventArgs e)
        {
            if (txtconfirmar.Visible == true && contrasenaTextBox.Text.Length <= 6
                && contrasenaTextBox.ReadOnly == false && txtnueva.Visible == true)
            {
                lblcamb.Visible = true;
                lblcamb.Text = "LA CONTRASEÑA TIENE QUE SER MAYOR A 6 CARACTERES";
            }
            else
            {
                lblcamb.Visible = false;
            }
        }

        private void txtnueva_Leave(object sender, EventArgs e)
        {
            if (txtnueva.Text.Length <= 6 && contrasenaTextBox.ReadOnly == true && txtnueva.Text != "")
            {
                lblcamb1.Visible = true;
                lblcamb1.Text = "LA CONTRASEÑA TIENE QUE SER MAYOR A 6 CARACTERES";
            }
            else
            {
                lblcamb1.Visible = false;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtconfirmar.Text.Length <= 6 && txtconfirmar.Text != "")
            {
                lblcamb2.Visible = true;
                lblcamb2.Text = "LA CONTRASEÑA TIENE QUE SER MAYOR A 6 CARACTERES";
            }

            if (txtconfirmar.Text.Length > 6)
            {
                lblcamb2.Visible = false;
            }

            if (txtconfirmar.Text != txtnueva.Text || txtconfirmar.Text != contrasenaTextBox.Text
                && contrasenaTextBox.ReadOnly == false)
            {
                lblcamb2.Visible = true;
                lblcamb2.Text = "Las contraseñas no coinciden";
            }

            if (txtconfirmar.Text == contrasenaTextBox.Text)
            {
                lblcamb2.Visible = false;
            }
        }

        private void contrasenaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (contrasenaTextBox.Text == txtconfirmar.Text)
            {
                lblcamb2.Visible = false;
            }

            if (contrasenaTextBox.Text != txtconfirmar.Text && txtconfirmar.Text != "")
            {
                lblcamb2.Visible = true;
                lblcamb2.Text = "Las contraseñas no coinciden";
            }

            if (contrasenaTextBox.Text.Length <= 6 && contrasenaTextBox.Text != ""
                && contrasenaTextBox.ReadOnly == false && txtnueva.Visible == false)
            {
                lblcamb.Visible = true;
                lblcamb.Text = "LA CONTRASEÑA TIENE QUE SER MAYOR A 6 CARACTERES";
            }
            else
            {
                lblcamb.Visible = false;
            }
        }

        private void txtnueva_TextChanged(object sender, EventArgs e)
        {
            if (txtnueva.Text == txtconfirmar.Text)
            {
                lblcamb2.Visible = false;
            }

            if (txtnueva.Text != txtconfirmar.Text && txtconfirmar.Text != "")
            {
                lblcamb2.Visible = true;
                lblcamb2.Text = "Las contraseñas no coinciden";
            }

            if (txtnueva.Text.Length <= 6 && contrasenaTextBox.ReadOnly == true && txtnueva.Text.Length > 0)
            {
                lblcamb1.Visible = true;
                lblcamb1.Text = "LA CONTRASEÑA TIENE QUE SER MAYOR A 6 CARACTERES";
            }
            else
            {
                lblcamb1.Visible = false;
            }
        }

        private void txtconfirmar_TextChanged(object sender, EventArgs e)
        {
            if (txtconfirmar.Text.Length <= 6)
            {
                lblcamb2.Visible = true;
                lblcamb2.Text = "LA CONTRASEÑA TIENE QUE SER MAYOR A 6 CARACTERES";
            }

            if (txtconfirmar.Text.Length > 6)
            {
                lblcamb2.Visible = false;
            }

            if (txtconfirmar.Text != txtnueva.Text || txtconfirmar.Text != contrasenaTextBox.Text
                && contrasenaTextBox.ReadOnly == false)
            {
                lblcamb2.Visible = true;
                lblcamb2.Text = "Las contraseñas no coinciden";
            }

            if (txtconfirmar.Text == contrasenaTextBox.Text)
            {
                lblcamb2.Visible = false;
            }
        }
        #endregion

        //CANCELAR CAMBIOS
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            nombUsuarioTextBox.Focus();

            lblcamb.Visible = false;
            lblcamb1.Visible = false;
            lblcamb2.Visible = false;
            bindingNavigatorDeleteItem.Enabled = true;

            _seguridad.CancelarCambios();
            lblcamb.Visible = false;

            contrasenaTextBox.ReadOnly = true;
            contrasenaTextBox.BackColor = Color.Silver;
            lblcamb.Visible = false;

            if (txtnueva.Visible == false)
            {
                txtnueva.Visible = true;
            }

            txtconfirmar.Text = "";
            txtnueva.Text = "";
            

        }

        private void fechaInicioDateTimePicker_Validating(object sender, CancelEventArgs e)
        {

        }
    }
}
