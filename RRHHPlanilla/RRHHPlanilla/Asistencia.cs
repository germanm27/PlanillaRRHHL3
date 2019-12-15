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

namespace RRHHPlanilla
{
    public partial class Asistencia : Form
    {

        TrabajadoresBL _trabajadores;
        CargosBL _cargosBL;
        JornadaBL _jornadaBL;
        //AsistenciaBL _asistenciaBL;

        public Asistencia()
        {
            InitializeComponent();

            //_asistenciaBL = new AsistenciaBL();
            //listaAsistenciaBindingSource.DataSource = _asistenciaBL.ListaAsistencia;

            _trabajadores = new TrabajadoresBL();
            listaTrabajadoresBindingSource.DataSource = _trabajadores.ListaTrabajadores;  //ObtenerTrabajador();

            _cargosBL = new CargosBL();
            listaCargosBindingSource.DataSource = _cargosBL.ObtenerCargos();

            _jornadaBL = new JornadaBL();
            listaJornadasBindingSource.DataSource = _jornadaBL.ObtenerJornadas();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(" "))
            {
                SendKeys.Send("{BACKSPACE}");
                SendKeys.Send("{TAB}");
            }
        }

        private void capturar()
        {
          
            if (nombreTextBox.Text != " ")
            {


                //_asistenciaBL.AgregarAsistencia();
                //listaAsistenciaBindingSource.MoveLast();


                //listaAsistenciaBindingSource.EndEdit();
                //var asistencia = (Asistencia2)listaAsistenciaBindingSource.Current;

                //asistencia.Nombre = nombreTextBox.Text; 
                //asistencia.Cedula = cedulaTextBox.Text;
                //asistencia.Cargo = comboBox1.Text;
                //asistencia.Jornada = comboBox2.Text;

                //if (nombreTextBox1.Text != " ")
                //{
                //    asistencia.FechaEntrada = dateTimePicker1.Value;
                //}
                //else
                //{
                //    asistencia.FechaSalida = dateTimePicker1.Value;
                //}

                //_asistenciaBL.GuardaAsistencias(asistencia);

                //var resultado = _asistenciaBL.GuardaAsistencias(asistencia);
                //if (resultado.Exitoso == true)
                //{
                //    listaAsistenciaBindingSource.ResetBindings(false);

                //    DialogResult resul = MessageBox.Show("Vacaciones del Empleado guardado ", "Exitoso...!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //}
                //else
                //{
                //    MessageBox.Show(resultado.Mensaje);
                //}

            }

        }

        private void busqueda()
        {
            ////BUSQUEDA
            //var buscar = textBox1.Text;

            //if (string.IsNullOrEmpty(buscar) == true)
            //{
            //    _asistenciaBL = new AsistenciaBL();
            //    listaAsistenciaBindingSource.DataSource = _asistenciaBL.ListaAsistencia;
            //}

            //if (string.IsNullOrEmpty(buscar) != true)
            //{

            //    listaAsistenciaBindingSource.DataSource =
            //        _asistenciaBL.ObtenerAsistencia2(buscar);

            //    listaAsistenciaBindingSource.ResetBindings(false);
            //}

            #region //PRUEBA
            //string dia, mes, año, hora;

            ////Capturando Fechas

            //dia = dateTimePicker1.Value.Date.ToString("dd");
            //mes = dateTimePicker1.Value.Date.ToString("MM");
            //año = dateTimePicker1.Value.Date.ToString("yyyy");
            //hora = dateTimePicker1.Value.Date.ToString("hh:mm:ss");

            //DateTime fecha1 = Convert.ToDateTime("07/08/2012 09:15:29 a.m.");

            //DateTime fechatemp = Convert.ToDateTime("04:15:29 p.m.");

            //DateTime fecha2 = new DateTime(fecha1.Year, fecha1.Month, fecha1.Day, fechatemp.Hour, fechatemp.Minute, fechatemp.Second);

            //if (fecha1 > fecha2)
            //{

            //}
            #endregion

            //_asistenciaBL.AgregarAsistencia();
            //listaAsistenciaBindingSource.MoveLast();


            //listaAsistenciaBindingSource.EndEdit();
            //var asistencia = (Asistencia2)listaAsistenciaBindingSource.Current;

            //asistencia.Nombre = nombreTextBox.Text;
            //asistencia.Cedula = cedulaTextBox.Text;
            //asistencia.Cargo = comboBox1.Text;
            //asistencia.Jornada = comboBox2.Text;

            //if (nombreTextBox1.Text != " ")
            //{
            //    asistencia.FechaEntrada = dateTimePicker1.Value;
            //}
            //else
            //{
            //    asistencia.FechaSalida = dateTimePicker1.Value;
            //}

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Enabled == true)
            {

                var buscar = textBox1.Text;
                var buscar2 = textBox2.Text;

                if (string.IsNullOrEmpty(buscar) == true)
                {
                    _trabajadores = new TrabajadoresBL();
                    listaTrabajadoresBindingSource.DataSource = _trabajadores.ListaTrabajadores;
                }

                if (string.IsNullOrEmpty(buscar) != true)
                {
                    listaTrabajadoresBindingSource.DataSource =
                        _trabajadores.ObtenerTrabajador2(buscar, buscar2);

                    listaTrabajadoresBindingSource.ResetBindings(false);
                }

                //busqueda();
                //capturar();

                //TIMER

                contador2 = 5;
                this.label3.Text = Convert.ToInt32(contador).ToString();
                this.timer2.Enabled = true;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            contador = contador - 1;
            this.label3.Text = contador.ToString();
            if (contador == 0)
            {
                this.timer1.Enabled = false;             
                textBox1.ResetText();
                textBox2.ResetText();

                textBox1.Enabled = true;
                textBox2.Enabled = true;
                textBox1.Focus();


                    _trabajadores = new TrabajadoresBL();
                    listaTrabajadoresBindingSource.DataSource = _trabajadores.ListaTrabajadores;
               
            }
        }

        int contador;
        int contador2;

        private void Asistencia_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            contador2 = contador2 - 1;
            this.label3.Text = contador2.ToString();
            if (contador2 == 0)
            {
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                
                this.timer2.Enabled = false;



                contador = 50;
                this.label3.Text = Convert.ToInt32(contador).ToString();
                this.timer1.Enabled = true;
            }
        }

        private void HoraFecha_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("h:mm:ss");
            lblfecha.Text = DateTime.Now.ToShortDateString();
        }
    }
 
}
