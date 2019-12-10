using RRHH.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRHHPlanilla
{
    public partial class Empleados : Form
    {
        TrabajadoresBL _trabajadores;
        CargosBL _cargosBL;
        JornadaBL _jornadaBL;
        EstadoCivilBL _estadocivilBL;
        MetodoPagoBL _metodopagoBL;
        SexoBL _sexoBL;

        public Empleados()
        {
            InitializeComponent();

            _sexoBL = new SexoBL();
            listaSexosBindingSource.DataSource = _sexoBL.ObtenerSexos();

            _trabajadores = new TrabajadoresBL();
            listaTrabajadoresBindingSource.DataSource = _trabajadores.ObtenerTrabajador();

            _cargosBL = new CargosBL();
            listaCargosBindingSource.DataSource = _cargosBL.ObtenerCargos();

            _jornadaBL = new JornadaBL();
            listaJornadasBindingSource.DataSource = _jornadaBL.ObtenerJornadas();

            _estadocivilBL = new EstadoCivilBL();
            listaEstadoCivilesBindingSource.DataSource = _estadocivilBL.ObtenerEstadoCiviles();

            _metodopagoBL = new MetodoPagoBL();
            listaMetodoPagosBindingSource.DataSource = _metodopagoBL.ObtenerMetodoPagos();

        }
        #region BotonesEdicion
        public void HabilitarEdicion()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            nombreTextBox.Enabled = true;
            apellidoTextBox.Enabled = true;
            edadTextBox.Enabled = true;
            sueldoTextBox.Enabled = true;
            direccionTextBox.Enabled = true;
            cedulaTextBox.Enabled = true;
            fechaInicioDateTimePicker.Enabled = true;
            comboBox1.Enabled = true;
            estadoCivilIdComboBox.Enabled = true;
            cargoIdComboBox.Enabled = true;
            metodoPagoIdComboBox.Enabled = true;
            jornadaIdComboBox.Enabled = true;
        }

        public void DesabilitarEdicion()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            nombreTextBox.Enabled = false;
            apellidoTextBox.Enabled = false;
            edadTextBox.Enabled = false;
            sueldoTextBox.Enabled = false;
            direccionTextBox.Enabled = false;
            cedulaTextBox.Enabled = false;
            fechaInicioDateTimePicker.Enabled = false;
            comboBox1.Enabled = false;
            estadoCivilIdComboBox.Enabled = false;
            cargoIdComboBox.Enabled = false;
            metodoPagoIdComboBox.Enabled = false;
            jornadaIdComboBox.Enabled = false;
        }
        #endregion

        //GUARDAR
        private void listaTrabajadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaTrabajadoresBindingSource.EndEdit();
            var trabajador = (Trabajador)listaTrabajadoresBindingSource.Current;

            if (fotoPictureBox.Image != null)
            {
                trabajador.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                trabajador.Foto = null;
            }
            var resultado = _trabajadores.GuardarTrabajador(trabajador);

           
            if (resultado.Exitoso == true)
            {
                listaTrabajadoresBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                DialogResult resul = MessageBox.Show("Usuario Guardado", "Exitoso...!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                listaTrabajadoresBindingNavigatorSaveItem.Enabled = false;
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        //AGREGAR
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            listaTrabajadoresBindingNavigatorSaveItem.Enabled = true;
            _trabajadores.AgregarTrabajador();
            listaTrabajadoresBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
            HabilitarEdicion();

        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;
            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripCancelar.Visible = !valor;
            toolStripButton1.Enabled = valor;
        }

        //BORRAR
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            
            if (idTextBox.Text != "")
            {
                DialogResult resulto = MessageBox.Show("¿Desea Eliminar el Registro?", "Eliminar", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resulto == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        //ELIMINAR
        private void Eliminar(int id)
        {
            var resultado = _trabajadores.EliminarTrabajador(id);

            if (resultado == true)
            {
                listaTrabajadoresBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar un trabajador");
            }
        }

        //CANCELAR CAMBIOS
        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            _trabajadores.CancelarCambios();
            DesabilitarEdicion();
            listaTrabajadoresBindingNavigatorSaveItem.Enabled = false;
            DeshabilitarHabilitarBotones(true);       
        }
     
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Trabajadores_Load(object sender, EventArgs e)
        {
            toolStripCancelar.Visible = false;
            listaTrabajadoresBindingNavigatorSaveItem.Enabled = false;
            DesabilitarEdicion();
        }


        private void listaTrabajadoresBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {

        }
        private void listaTrabajadoresBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        //FOTO
        private void button1_Click(object sender, EventArgs e)
        {
            var trabajador = (Trabajador)listaTrabajadoresBindingSource.Current;
            
            if (trabajador != null)
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

        private void piccerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            listaTrabajadoresBindingNavigatorSaveItem.Enabled = true;
            toolStripCancelar.Visible = true;
            toolStripCancelar.Enabled = true;
            HabilitarEdicion();
        }
    }
}
