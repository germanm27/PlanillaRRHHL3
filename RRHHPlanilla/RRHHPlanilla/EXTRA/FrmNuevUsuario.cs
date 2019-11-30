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

namespace RRHHPlanilla
{
    public partial class FrmConfiUsuario : Form
    {
        SeguridadBL _seguridad;
        public FrmConfiUsuario()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
            listaSeguridadBindingSource.DataSource = _seguridad.ObtenerUsuario();
        }

        

        #region Drag Form/ Mover Arrastrar Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FrmConfiUsuario_MouseDown(object sender, MouseEventArgs e)
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

        private void FrmConfiUsuario_Load(object sender, EventArgs e)
        {
            txtnombre.Text = Program.usuario.Nombre + " " + Program.usuario.Apellido;
            textBox1.Text = Program.usuario.Privilegio.Descripcion;

            txtnuevcont.Text = Program.usuario.Contrasena;
            txtcorreo.Text = Program.usuario.Correo;
           
            
            txtedad.Text = Program.usuario.edad.ToString();
            txtcedula.Text = Program.usuario.Cedula.ToString();
            txtusuario.Text = Program.usuario.NombUsuario;

            if (Program.usuario.Foto != null)
            {
                MemoryStream ms = new MemoryStream(Program.usuario.Foto);
                System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
                fotoPictureBox.Image = Image.FromStream(ms);
            }
        }

        private void txtusuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
