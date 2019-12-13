using RRHH.BL;
using RRHHPlanilla.Transacciones.Vacaciones;
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
    public partial class Vacaciones : Form
    {
        TrabajadoresBL _trabajadores;
        CargosBL _cargosBL;
        JornadaBL _jornadaBL;
        EstadoCivilBL _estadocivilBL;
        MetodoPagoBL _metodopagoBL;
        SexoBL _sexoBL;
        VacacionesBL _vacacionesBL;

        public Vacaciones()
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

            _vacacionesBL = new VacacionesBL();
            listaVacacionesBindingSource.DataSource = _vacacionesBL.ObtenerVacaciones();

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
           
        }

        //CANCELAR CAMBIOS
        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            _trabajadores.CancelarCambios();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vacaciones_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {

            int dias = (int)(finalizavacacionDateTimePicker.Value - iniciavacacionDateTimePicker.Value).TotalDays;
            //obtenidoTextBox.Text = dias.ToString();

            string obtenidos = disponibleDiaTextBox.Text;
            int obtenidos2;

            //variables de para fechas de inicio, final, actual y antiguedad
            string dia, mes, año;
            string finaldia, finalmes, finalaño;
            int antidia, antimes, antiaño;
            int Disponible = 0, Obtenido = 0, Pago = 0, sueldo = 0, mensual = 0, diario = 0;

            obtenidos2 = Convert.ToInt32(obtenidos);
            dias = dias + 1;


            //Capturando Fechas inicio , final, actual  convertiendo a string
            dia = fechaInicioDateTimePicker.Value.Date.ToString("dd");
            mes = fechaInicioDateTimePicker.Value.Date.ToString("MM");
            año = fechaInicioDateTimePicker.Value.Date.ToString("yyyy");

            finaldia = dateTimePicker3.Value.Date.ToString("dd");
            finalmes = dateTimePicker3.Value.Date.ToString("MM");
            finalaño = dateTimePicker3.Value.Date.ToString("yyyy");



            // Sacando la Antiguedad
            antidia = Convert.ToInt32(finaldia) - Convert.ToInt32(dia);
            antimes = Convert.ToInt32(finalmes) - Convert.ToInt32(mes);
            antiaño = Convert.ToInt32(finalaño) - Convert.ToInt32(año);

            //Capturando dias de vacaciones   
            #region Captura

            if (disponibleDiaTextBox.Text == "0" && fechaGeneradoTextBox.Text != "Si")
            {
                if (antiaño >= 4)
                {
                    Disponible = 20;
                    disponibleDiaTextBox.Text = "20";
                    fechaGeneradoTextBox.Text = "Si";
                    MessageBox.Show("Los Dias Fueron Generados ");

                }

                else if (antiaño == 3)
                {
                    Disponible = 15;
                    disponibleDiaTextBox.Text = "15";
                    fechaGeneradoTextBox.Text = "Si";
                    MessageBox.Show("Los Dias Fueron Generados ");

                }
                else if (antiaño == 2)
                {
                    Disponible = 12;
                    disponibleDiaTextBox.Text = "12";
                    fechaGeneradoTextBox.Text = "Si";
                    MessageBox.Show("Los Dias Fueron Generados ");

                }

                else if (antiaño == 1)
                {
                    Disponible = 10;
                    disponibleDiaTextBox.Text = "10";
                    fechaGeneradoTextBox.Text = "Si";
                    MessageBox.Show("Los Dias Fueron Generados ");

                }

                else if (antidia <= 0)
                {
                    MessageBox.Show("No tiene Aun 1 año de antiguedad para obtener Vacaciones");
                    fechaGeneradoTextBox.Text = "Si";
                    MessageBox.Show("Los Dias Fueron Generados ");

                }

            }


            if (Convert.ToUInt32(disponibleDiaTextBox.Text) <= 0)
            {
                MessageBox.Show("No hay Dias Disponibles");
                disponibleDiaTextBox.Text = "0";
                button2.Enabled = false;
            }


            else
            {
                Disponible = Convert.ToInt32(disponibleDiaTextBox.Text);
            }


            if (dias < 0)
            {
                MessageBox.Show("Las fecha ingresada  no es valida, Ingrese Valores Correctos");
            }

            else if (dias <= obtenidos2)
            {
                obtenidoTextBox.Text = dias.ToString();


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

                //Impresion de Antiguedad 
                textBox21.Text = Convert.ToString(antiaño);
                textBox20.Text = Convert.ToString(antimes);
                textBox19.Text = Convert.ToString(antidia);

                //Calculo de Salario Real
                sueldo = Convert.ToInt32(sueldoTextBox.Text);
                mensual = (sueldo * 14) / 12;
                diario = mensual / 30;



                if (obtenidoTextBox.Text == "")
                {
                    MessageBox.Show("Ingrese los dias a obtener");
                }
                else
                {
                    Obtenido = Convert.ToInt32(obtenidoTextBox.Text);

                }

                #endregion

                //Calculando el pago de vacaciones
                Pago = diario * Obtenido;
                if (Disponible > 0)
                {
                    Disponible = Disponible - Obtenido;

                }
                else
                {
                    Disponible = 0;
                }

                //Imprimiendo datos
                disponibleDiaTextBox.Text = Convert.ToString(Disponible);
                obtenidoTextBox.Text = Convert.ToString(Obtenido);
                pagoTextBox.Text = Convert.ToString(Pago);

                //Desabilitacion de boton calcular
                if (disponibleDiaTextBox.Text == "0")
                {
                    button1.Enabled = true;
                    button2.Enabled = false;

                }

                button1.Enabled = true;
                button2.Enabled = false;



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int generado = 0;

            //captura de vacaciones generadas
            if (fechaGeneradoTextBox.Text == "Si")
            {
                generado = 1;
            }




            if (disponibleDiaTextBox.Text == "0" || obtenidoTextBox.Text == null)
            {
                MessageBox.Show("Ya no hay Vacaciones disponibles");
                button1.Enabled = false;
            }
            else
            {
                button2.Enabled = true;

            }



            _vacacionesBL.AgregarVacacion();
            listaVacacionesBindingSource.MoveLast();

            //Guardando datos en tabla vacaciones
            listaVacacionesBindingSource.EndEdit();

            var vacacion = (Vacacion)listaVacacionesBindingSource.Current;

            vacacion.Nombre = nombreTextBox.Text;
            vacacion.Disponible = Convert.ToInt32(disponibleDiaTextBox.Text);
            vacacion.Obtenido = Convert.ToInt32(obtenidoTextBox.Text);
            vacacion.Iniciavacacion = iniciavacacionDateTimePicker.Value;
            vacacion.Finalizavacacion = finalizavacacionDateTimePicker.Value;
            vacacion.Pago = Convert.ToInt32(pagoTextBox.Text);
            vacacion.TrabajadorId = Convert.ToInt32(idTextBox.Text);
            _vacacionesBL.GuardaVacaciones(vacacion);

            //Guardando datos en tabla trabajador
            var diadisponible = (Trabajador)listaTrabajadoresBindingSource.Current;
            diadisponible.DisponibleDia = Convert.ToInt32(disponibleDiaTextBox.Text);
            diadisponible.FechaGenerado = generado;
            _trabajadores.GuardarTrabajador(diadisponible);




            var resultado = _vacacionesBL.GuardaVacaciones(vacacion);
            if (resultado.Exitoso == true)
            {
                listaVacacionesBindingSource.ResetBindings(false);

                DialogResult resul = MessageBox.Show("Vacaciones del Empleado guardado ", "Exitoso...!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                button1.Enabled = false;
                button2.Enabled = false;


            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

            obtenidoTextBox.Clear();
            listaTrabajadoresBindingSource.Clear();
            fechaGeneradoTextBox.Clear();
            textBox19.Clear();
            textBox20.Clear();
            textBox21.Clear();
            pagoTextBox.Clear();

            button2.Enabled = false;

        }

        private void bindingNavigatorMoveNextItem_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void listaTrabajadoresBindingNavigator_RefreshItems_1(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            ResultadoVacaciones f4 = new ResultadoVacaciones();

                f4.Show();
          }

        private void button5_Click(object sender, EventArgs e)
        {
            var buscar1 = comboBox2.Text;
            var buscar2 = textBox12.Text;

            listaTrabajadoresBindingSource.DataSource = _trabajadores.ObtenerTrabajador(buscar1, buscar2);

            listaTrabajadoresBindingSource.ResetBindings(false);

            if (nombreTextBox.Text != "")
            {
                iniciavacacionDateTimePicker.Enabled = true;
                finalizavacacionDateTimePicker.Enabled = true;
                button1.Enabled = true;
                button2.Enabled = true;

                comboBox2.ResetText();
                textBox12.Clear();
            }
            if (nombreTextBox.Text == "")
            {
                iniciavacacionDateTimePicker.Enabled = false;
                finalizavacacionDateTimePicker.Enabled = false;
                button1.Enabled = false;
                button2.Enabled = false;
            }

            if (idTextBox.Text == "")
            {
                MessageBox.Show("Empleado no Encontrado intentelo de nuevo");
            }

            if (fechaGeneradoTextBox.Text == "1")
            {
                fechaGeneradoTextBox.Text = "Si";

            }
            else
            {
                fechaGeneradoTextBox.Text = "No";

            }
            button1.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
