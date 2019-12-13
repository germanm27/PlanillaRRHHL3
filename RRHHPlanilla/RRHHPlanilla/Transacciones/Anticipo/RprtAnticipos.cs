using RRHH.BL;
using RRHHPlanilla.Transacciones.Anticipo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRHHPlanilla
{
    public partial class Anticipos : Form
    {
        TrabajadoresBL _trabajadores;
        CargosBL _cargosBL;
        JornadaBL _jornadaBL;
        EstadoCivilBL _estadocivilBL;
        MetodoPagoBL _metodopagoBL;
        SexoBL _sexoBL;
        AnticiposBL _anticipoBL;

        public Anticipos()
        {
            InitializeComponent();

            _sexoBL = new SexoBL();
            listaSexosBindingSource.DataSource = _sexoBL.ObtenerSexos();

            _trabajadores = new TrabajadoresBL();
            listaTrabajadoresBindingSource.DataSource = _trabajadores.ListaTrabajadores;

            _cargosBL = new CargosBL();
            listaCargosBindingSource.DataSource = _cargosBL.ObtenerCargos();

            _jornadaBL = new JornadaBL();
            listaJornadasBindingSource.DataSource = _jornadaBL.ObtenerJornadas();

            _estadocivilBL = new EstadoCivilBL();
            listaEstadoCivilesBindingSource.DataSource = _estadocivilBL.ObtenerEstadoCiviles();

            _metodopagoBL = new MetodoPagoBL();
            listaMetodoPagosBindingSource.DataSource = _metodopagoBL.ObtenerMetodoPagos();

            _anticipoBL = new AnticiposBL();
            listaAnticiposBindingSource.DataSource = _anticipoBL.ObtenerAnticipos();


        }

        //GUARDAR
        private void listaTrabajadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        }
           

        //AGREGAR
        //private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        //{
        //    listaTrabajadoresBindingNavigatorSaveItem.Enabled = true;
        //    _trabajadores.AgregarTrabajador();
        //    listaTrabajadoresBindingSource.MoveLast();

        //    DeshabilitarHabilitarBotones(false);
        //}


        private void DeshabilitarHabilitarBotones(bool valor)
        {
            

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
            DeshabilitarHabilitarBotones(true);
        }

      
        private void Anticipos_Load(object sender, EventArgs e)
        {
         
            

        }

        private void listaTrabajadoresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listaTrabajadoresBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void listaTrabajadoresBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

       

        private void piccerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void sueldoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
                ResultadoAnticipo f4 = new ResultadoAnticipo();

                f4.Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sueldoBruto = 0, sueldoNeto=0, anticipo=0;

            sueldoBruto = Convert.ToInt32(sueldoTextBox1.Text);

            if (textBox1.Text == "")
            {
                MessageBox.Show("Ingrese el anticipo que desea");
            }
            else
            {
                anticipo = Convert.ToInt32(textBox1.Text);
                sueldoNeto = sueldoBruto - anticipo;
                textBox2.Text = Convert.ToString(sueldoNeto);
            }
           



        }

        private void button2_Click(object sender, EventArgs e)
        {
            _anticipoBL.AgregarAnticipo();
            listaAnticiposBindingSource.MoveLast();
            
            //Guardando datos en tabla vacaciones
            listaAnticiposBindingSource.EndEdit();
            var anticipo = (Anticipo)listaAnticiposBindingSource.Current;

            anticipo.Nombre = nombreTextBox.Text;
            anticipo.SueldoBruto = Convert.ToInt32(sueldoTextBox1.Text);
            anticipo.Anti = Convert.ToInt32(textBox1.Text);
            anticipo.FechaAnticipo = dateTimePicker1.Value;
            anticipo.SueldoNeto = Convert.ToInt32(textBox2.Text); 
            anticipo.TrabajadorId = Convert.ToInt32(idTextBox.Text);
            _anticipoBL.GuardaAnticipos(anticipo);

            var traba = (Trabajador)listaTrabajadoresBindingSource.Current;
            traba.Sueldo = Convert.ToInt32(textBox2.Text);
            _trabajadores.GuardarTrabajador(traba);

            var resultado = _anticipoBL.GuardaAnticipos(anticipo);
            if (resultado.Exitoso == true)
            {
                listaAnticiposBindingSource.ResetBindings(false);

                DialogResult resul = MessageBox.Show("Anticipo del Empleado guardado ", "Exitoso...!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                listaTrabajadoresBindingSource.DataSource = _trabajadores.ObtenerTrabajador();

                button3.Enabled = false;
                button2.Enabled = false;
                textBox1.Enabled = false;
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

            textBox1.Clear();
            textBox2.Clear();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
                var buscar1 = comboBox2.Text;
                var buscar2 = textBox3.Text;

                listaTrabajadoresBindingSource.DataSource = _trabajadores.ObtenerTrabajador(buscar1, buscar2);

                listaTrabajadoresBindingSource.ResetBindings(false);
            if (nombreTextBox.Text != "")
            {
                button3.Enabled = true;
                button2.Enabled = true;
                textBox1.Enabled = true;

                comboBox2.SelectedIndex = -1;
                textBox3.Clear();
            }
            if (nombreTextBox.Text == "")
            {
                button3.Enabled = false;
                button2.Enabled = false;
                textBox1.Enabled = false;
            }
               

            
        }
    }
    }

