using RRHH.BL;
using RRHHPlanilla.Transacciones.Prestaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRHHPlanilla
{
    public partial class Prestaciones : Form
    {
        Contexto contexto;
        TrabajadoresBL _trabajadores;
        CargosBL _cargosBL;
        JornadaBL _jornadaBL;
        EstadoCivilBL _estadocivilBL;
        MetodoPagoBL _metodopagoBL;
        SexoBL _sexoBL;
        ExTrabajadoresBL _ExTrabajadoresBL;

        public Contexto Contexto
        {
            get
            {
                return contexto;
            }

            set
            {
                contexto = value;
            }
        }

        public Prestaciones()
        {
            InitializeComponent();

            _sexoBL = new SexoBL();
            listaSexosBindingSource.DataSource = _sexoBL.ObtenerSexos();

            _trabajadores = new TrabajadoresBL();
            listaTrabajadoresBindingSource.DataSource = _trabajadores.ListaTrabajadores;   //ObtenerTrabajador();

            _cargosBL = new CargosBL();
            listaCargosBindingSource.DataSource = _cargosBL.ObtenerCargos();

            _jornadaBL = new JornadaBL();
            listaJornadasBindingSource.DataSource = _jornadaBL.ObtenerJornadas();

            _estadocivilBL = new EstadoCivilBL();
            listaEstadoCivilesBindingSource.DataSource = _estadocivilBL.ObtenerEstadoCiviles();

            _metodopagoBL = new MetodoPagoBL();
            listaMetodoPagosBindingSource.DataSource = _metodopagoBL.ObtenerMetodoPagos();

            _ExTrabajadoresBL = new ExTrabajadoresBL();
            listaExTrabajadoresBindingSource.DataSource = _ExTrabajadoresBL.ObtenerExTrabajador();
        }

        //GUARDAR
        private void listaTrabajadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {

        }

        //AGREGAR
        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }


        private void DeshabilitarHabilitarBotones(bool valor)
        {
           

        }

        //BORRAR
        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

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




        private void Prestaciones_Load(object sender, EventArgs e)
        {
            //listaTrabajadoresBindingSource.Clear();
        }


        private void listaTrabajadoresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void listaTrabajadoresBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }



        private void fotoPictureBox_Click(object sender, EventArgs e)
        {

        }



        private void piccerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripCancelar_Click_1(object sender, EventArgs e)
        {
            _trabajadores.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void bindingNavigatorMoveNextItem_Click_1(object sender, EventArgs e)
        {

        }

        private void listaTrabajadoresBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TablaPrestaciones f4 = new TablaPrestaciones();

            f4.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //variables de para fechas de inicio, final, actual y antiguedad
            string dia, mes, año;
            string finaldia, finalmes, finalaño;
            int antidia, antimes, antiaño;
            int sueldo = 0, mensual = 0, diario = 0, preaviso = 0, cesantia = 0, cesantiapro = 0, vacacion = 0, total_prestaciones = 0;
            int cantidadDia = 0;
            //Capturando Fechas inicio , final, actual  convertiendo a string
            dia = dateTimePicker1.Value.Date.ToString("dd");
            mes = dateTimePicker1.Value.Date.ToString("MM");
            año = dateTimePicker1.Value.Date.ToString("yyyy");

            finaldia = dateTimePicker2.Value.Date.ToString("dd");
            finalmes = dateTimePicker2.Value.Date.ToString("MM");
            finalaño = dateTimePicker2.Value.Date.ToString("yyyy");



            // Sacando la Antiguedad
            antidia = Convert.ToInt32(finaldia) - Convert.ToInt32(dia);
            antimes = Convert.ToInt32(finalmes) - Convert.ToInt32(mes);
            antiaño = Convert.ToInt32(finalaño) - Convert.ToInt32(año);

            if (antidia < 0)
            {
                int a;
                a = 30 - Convert.ToInt32(dia);
                antidia = a + Convert.ToInt32(finaldia);
            }
            else
            {
                antidia = Convert.ToInt32(finaldia) - Convert.ToInt32(dia);
            }

            
            //Calculos de Prestaciones
            sueldo = Convert.ToInt32(textBox13.Text);
            mensual = (sueldo * 14) / 12;
            diario = mensual / 30;

            //calculos de vacaciones
            cantidadDia = Convert.ToInt32(disponibleDiaTextBox.Text);
            vacacion = cantidadDia * diario;

            //Preaviso
            if (antiaño > 0)
            {
                preaviso = mensual * 2;

            }
            else
            {
                preaviso = mensual * 14;

            }

            //Cesantia Pro
            if (antiaño < 15)
            {
                if (antidia > 0 || antimes > 0)
                {
                    int totaldias, diaPro;
                    totaldias = (antimes * 30) + antidia;
                    diaPro = totaldias * 30 / 360;
                    cesantiapro = diaPro * diario;
                }
            }
            else
            {
                cesantiapro = 0;
            }

            //Cesantias
            if (antiaño > 15)
            {
                cesantia = mensual * 15;
            }
            else
            {
                cesantia = mensual * antiaño;
            }

            total_prestaciones = (preaviso + cesantia + cesantiapro + vacacion);


            //Impresion de datos
            textBox3.Text = año;
            textBox4.Text = mes;
            textBox5.Text = dia;
            textBox2.Text = Convert.ToString(mensual);
            textBox6.Text = Convert.ToString(diario);
            textBox7.Text = Convert.ToString(preaviso);
            textBox8.Text = Convert.ToString(cesantia);
            textBox9.Text = Convert.ToString(cesantiapro);
            textBox10.Text = Convert.ToString(vacacion);
            textBox11.Text = Convert.ToString(total_prestaciones);
            textBox19.Text = Convert.ToString(antidia);
            textBox20.Text = Convert.ToString(antimes);
            textBox21.Text = Convert.ToString(antiaño);



        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ExTrabajadoresBL.AgregarExTrabajador();
            listaExTrabajadoresBindingSource.MoveLast();
            DeshabilitarHabilitarBotones(false);

            listaExTrabajadoresBindingSource.EndEdit();
            var extrabajador = (ExTrabajador)listaExTrabajadoresBindingSource.Current;

            //*SexoID*//
            #region sexo
            //int sexo = 0;
            //string sexos;

            //if (comboBox4.Text == "1")
            //{
            //    sexo = 1;
            //    sexos = "Masculino";
            //}
            //else if (comboBox4.Text == "2")
            //{
            //    sexo = 2;
            //    sexos = "Femenino";

            //}
            //else
            //{
            //    sexo = 3;
            //    sexos = "otros..";

            //}
            #endregion
            //*Cargo*// 
            #region cargo
            int cargo = 0;

            if (comboBox1.Text == "1")
            {
                cargo = 1;
            }
            else if (comboBox1.Text == "2")
            {
                cargo = 2;
            }
            else if (comboBox1.Text == "3")
            {
                cargo = 3;
            }
            else
            {
                cargo = 4;
            }
            #endregion
            //*Jornada*//
            #region Jornada
            int jornada = 0;

            if (comboBox3.Text == "1")
            {
                jornada = 1;
            }
            else if (comboBox3.Text == "2")
            {
                jornada = 2;
            }

            else
            {
                jornada = 3;
            }
            #endregion
            //*Pago*//
            #region pago
            int pago = 0;

            if (comboBox2.Text == "1")
            {
                pago = 1;
            }
            else if (comboBox2.Text == "2")
            {
                pago = 2;
            }
            else if (comboBox2.Text == "3")
            {
                pago = 3;
            }
            else
            {
                pago = 4;
            }
            #endregion
           
      

            if (pictureBox2.Image != null)
            {
                extrabajador.Foto = Program.imageToByteArray(pictureBox2.Image);
            }
            else
            {
                extrabajador.Foto = null;
            }
            extrabajador.Nombre = textBox14.Text;
            extrabajador.Apellido = textBox17.Text;
            //extrabajador.Edad = Convert.ToInt32(textBox16.Text);
            //extrabajador.SexoId = sexo;
            extrabajador.Sueldo = Convert.ToInt32(textBox13.Text);
            //extrabajador.Direccion = textBox18.Text;
            //extrabajador.EstadoCivilId = 2;
            extrabajador.CargoId = cargo;
            extrabajador.MetodoPagoId = pago;
            extrabajador.JornadaId = jornada;
            extrabajador.FechaInicio = dateTimePicker1.Value;
            extrabajador.Cedula = Convert.ToDouble(textBox12.Text);
            extrabajador.FechaFinal = dateTimePicker2.Value;
            extrabajador.Motivo = textBox1.Text;
            extrabajador.SueldoMensual = Convert.ToInt32(textBox2.Text);
            extrabajador.SueldoDiario = Convert.ToInt32(textBox6.Text);
            extrabajador.Preaviso = Convert.ToInt32(textBox7.Text);
            extrabajador.Cesantia = Convert.ToInt32(textBox8.Text);
            extrabajador.CesantiaPro = Convert.ToInt32(textBox9.Text);
            extrabajador.Vacaciones = Convert.ToInt32(textBox10.Text);
            extrabajador.TotalPrestaciones = Convert.ToInt32(textBox11.Text);
            _ExTrabajadoresBL.GuardarExTrabajador(extrabajador);

            var resultado = _ExTrabajadoresBL.GuardarExTrabajador(extrabajador);

            if (resultado.Exitoso == true)
            {
                listaExTrabajadoresBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                //DialogResult resul = MessageBox.Show("Empleado Removido", "Exitoso...!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

            if (textBox15.Text != "")
            {
                DialogResult resulto = MessageBox.Show("¿Desea Eliminar el Registro?", "Eliminar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resulto == DialogResult.Yes)
                {
                    _trabajadores = new TrabajadoresBL();
                    listaTrabajadoresBindingSource.DataSource = _trabajadores.ObtenerTrabajador();

                    var id = Convert.ToInt32(textBox15.Text);
                    Eliminar(id);
                    MessageBox.Show("Empleado eliminado satisfactoriamente");

                }

            }

         
            textBox15.Clear();
            textBox14.Clear();
            textBox17.Clear();
            //textBox16.Clear();
            textBox13.Clear();
            //textBox18.Clear();
            disponibleDiaTextBox.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            textBox1.Clear();
            textBox2.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox10.Clear();
            textBox9.Clear();
            textBox11.Clear();
            

        }

        private void listaTrabajadoresBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
        {
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //listaTrabajadoresBindingSource.DataSource = true;

            var buscar1 = comboBox6.Text;
            var buscar2 = textBox22.Text;

            listaTrabajadoresBindingSource.DataSource = _trabajadores.ObtenerTrabajador(buscar1, buscar2);

            listaTrabajadoresBindingSource.ResetBindings(false);

            if (textBox14.Text != "")
            {
                textBox1.Enabled = true;
                button1.Enabled = true;
                button3.Enabled = true;

                comboBox6.SelectedIndex = -1;
                textBox22.Clear();
            }

            if (textBox14.Text == "")
            {
                textBox1.Enabled = false;
                button1.Enabled = false;
                button3.Enabled = false;
            }          

            if (textBox15.Text =="")
            {
                MessageBox.Show("Empleado no Encontrado intentelo de nuevo ");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
   
