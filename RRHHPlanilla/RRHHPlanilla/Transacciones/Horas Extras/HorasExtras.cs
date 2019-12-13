using RRHH.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRHHPlanilla.Transacciones.Horas_Extras
{
    public partial class HorasExtras : Form
    {
        TrabajadoresBL _trabajadores;
        CargosBL _cargosBL;
        JornadaBL _jornadaBL;
        EstadoCivilBL _estadocivilBL;
        MetodoPagoBL _metodopagoBL;
        SexoBL _sexoBL;
        HorasExtrasBL _horaextrasBL;

        public HorasExtras()
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

            _horaextrasBL = new HorasExtrasBL();
            listaHoraExtrasBindingSource.DataSource = _horaextrasBL.ObtenerHoraExtras();

        }


        //GUARDAR
        private void listaTrabajadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }
        //AGREGAR
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }


        ////private void DeshabilitarHabilitarBotones(bool valor)
        //{
        //    bindingNavigatorMoveFirstItem.Enabled = valor;
        //    bindingNavigatorMoveLastItem.Enabled = valor;
        //    bindingNavigatorMovePreviousItem.Enabled = valor;
        //    bindingNavigatorMoveNextItem.Enabled = valor;
        //    bindingNavigatorPositionItem.Enabled = valor;
        //    bindingNavigatorAddNewItem.Enabled = valor;
        //    bindingNavigatorDeleteItem.Enabled = valor;
        //    toolStripCancelar.Visible = !valor;

        //}

        //BORRAR
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {


        }

        //ELIMINAR
        private void Eliminar(int id)
        {
            var resultado = _horaextrasBL.EliminarHoraExtra(id);

            if (resultado == true)
            {
                listaHoraExtrasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar las horas extras");
            }
        }

        //CANCELAR CAMBIOS
        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            _horaextrasBL.CancelarCambios();
            //DeshabilitarHabilitarBotones(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HorasExtras_Load(object sender, EventArgs e)
        {
            //listaTrabajadoresBindingNavigatorSaveItem.Enabled = false;
           

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

        private void piccerrar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            ResultadoHoras f4 = new ResultadoHoras();

            f4.Show();

        }
       


        private void button3_Click_2(object sender, EventArgs e)
        {
            
                int sueldoBruto = 0, sueldodia = 0, Horas = 0;
                double sueldohora, horaextra, pago;

                sueldoBruto = Convert.ToInt32(sueldoTextBox.Text);
                sueldodia = sueldoBruto / 30;
                sueldohora = sueldodia / 8;
                horaextra = sueldohora * 1.25;

                if (textBox1.Text == "")
                {
                    MessageBox.Show("Ingrese las horas extras que desea");
                }
                else
                {
                    Horas = Convert.ToInt32(textBox1.Text);
                    pago = horaextra * Horas;
                    textBox2.Text = Convert.ToString(pago);
                }
          }
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                ResultadoHoras f4 = new ResultadoHoras();

                f4.Show();

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            _horaextrasBL.AgregarHoraExtra();
            listaHoraExtrasBindingSource.MoveLast();

            //Guardando datos en tabla hora extra
            listaHoraExtrasBindingSource.EndEdit();
            var horaextra = (HoraExtra)listaHoraExtrasBindingSource.Current;

            horaextra.Nombre = nombreTextBox.Text;
            horaextra.Cantidad = Convert.ToInt32(textBox1.Text);
            horaextra.Fecha = dateTimePicker1.Value;
            horaextra.Pago = Convert.ToInt32(textBox2.Text);
            horaextra.TrabajadorId = Convert.ToInt32(idTextBox.Text);
            _horaextrasBL.GuardaHoraExtras(horaextra);


            var resultado = _horaextrasBL.GuardaHoraExtras(horaextra);
            if (resultado.Exitoso == true)
            {
                listaHoraExtrasBindingSource.ResetBindings(false);

                DialogResult resul = MessageBox.Show("Horas Extras del Empleado guardado ", "Exitoso...!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                button3.Enabled = false;
                button2.Enabled = false;
                textBox1.Enabled = false;
                textBox1.Text = "";
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
                textBox1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;

                comboBox2.ResetText();
                textBox3.Clear();
            }
            if (nombreTextBox.Text == "")
            {
                textBox1.Enabled = false;
                button2.Enabled = false;
                button3.Enabled = false;
            }

            if (idTextBox.Text == "")
            {
                MessageBox.Show("Empleado no encontrado intentelo de nuevo");
            }

            button2.Enabled = false;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}