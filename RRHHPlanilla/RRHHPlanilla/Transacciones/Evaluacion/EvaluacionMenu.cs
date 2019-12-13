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
      
namespace WindowsFormsApplication1
{
    public partial class EvaluacionMenu : Form
    {
        TrabajadoresBL _trabajadores;
        CargosBL _cargosBL;
        JornadaBL _jornadaBL;
        EstadoCivilBL _estadocivilBL;
        MetodoPagoBL _metodopagoBL;
        SexoBL _sexoBL;
        public EvaluacionMenu()
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

        //CANCELAR CAMBIOS
        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            _trabajadores.CancelarCambios();
           
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void EvaluacionMenu_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label49_Click(object sender, EventArgs e)
        {

        }

        private void label60_Click(object sender, EventArgs e)
        {

        }

     

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox60_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox69_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void label119_Click(object sender, EventArgs e)
        {

        }

        private void comboBox67_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            
             }

        private void tabPage11_Click(object sender, EventArgs e)
        {

        }

        private void txtRutaImagen_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void textBox183_TextChanged(object sender, EventArgs e)
        {

        }

        private void label78_Click(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            {
                int inaceptable = 0, pobre = 0, aceptable = 0, bueno = 0, excelente = 0, subtotal = 0;
                if (comboBox22.Text != "Inaceptable" && comboBox22.Text != "Pobre" && comboBox22.Text != "Aceptable" && comboBox22.Text != "Bueno" && comboBox22.Text != "Excelente")
                {
                    MessageBox.Show("Realize la encuesta para poder calcular");
                }

                else
                {
                    #region Suma de Campos                                   
                  

                    //PRIMERA PARTE
                    switch (comboBox3.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;

                    }

                    switch (comboBox4.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }

                    switch (comboBox5.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }
                    switch (comboBox6.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }
                    switch (comboBox7.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }
                    switch (comboBox8.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }
                    switch (comboBox9.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }
                    //SEGUNDA PARTE
                    switch (comboBox10.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }

                    switch (comboBox11.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }

                    switch (comboBox12.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }
                    switch (comboBox13.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }
                    switch (comboBox14.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }
                    switch (comboBox15.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }
                    switch (comboBox16.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }
                    //TERCERA PARTE
                    switch (comboBox17.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }

                    switch (comboBox18.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }

                    switch (comboBox19.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }
                    switch (comboBox20.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }
                    switch (comboBox21.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }
                    switch (comboBox22.Text)
                    {
                        case "Inaceptable ":
                            inaceptable++;
                            inaceptable1.Text = Convert.ToString(inaceptable);
                            break;
                        case "Pobre":
                            pobre = pobre + 2;
                            pobre1.Text = Convert.ToString(pobre);
                            break;
                        case "Aceptable":
                            aceptable = aceptable + 3;
                            aceptable1.Text = Convert.ToString(aceptable);
                            break;
                        case "Bueno ":
                            bueno = bueno + 4;
                            bueno1.Text = Convert.ToString(bueno);
                            break;
                        case "Excelente":
                            excelente = excelente + 5;
                            excelente1.Text = Convert.ToString(excelente);
                            break;
                    }

                    //suma de campos
                    subtotal = inaceptable + pobre + aceptable + bueno + excelente;

                    subtotal1.Text = Convert.ToString(subtotal);
                    #endregion
                }
            }

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void fecha4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (subtotal1.Text == "" || subtotal1.Text == "0")
            { 
                MessageBox.Show("Realize la Encuestra para poder Continuar");
            }

            else
            {
                ResultadoEva f4 = new ResultadoEva();
                f4.idTextBox.Text = idTextBox.Text;
                f4.nombreTextBox.Text = nombreTextBox.Text;
                f4.apellidoTextBox.Text = apellidoTextBox.Text;
                f4.edadTextBox.Text = edadTextBox.Text;
                f4.comboBox1.Text = comboBox1.Text;
                //f4.sueldoTextBox.Text = sueldoTextBox.Text;
                //f4.direccionTextBox.Text = direccionTextBox.Text;
                //f4.estadoCivilIdComboBox.Text = estadoCivilIdComboBox.Text;
                f4.cedulaTextBox.Text = cedulaTextBox.Text;
                //f4.fechaInicioDateTimePicker.Text = fechaInicioDateTimePicker.Text;
                f4.cargoIdComboBox.Text = cargoIdComboBox.Text;
                f4.metodoPagoIdComboBox.Text = metodoPagoIdComboBox.Text;
                f4.jornadaIdComboBox.Text = jornadaIdComboBox.Text;
                f4.fotoPictureBox.Image = fotoPictureBox.Image;

                f4.inaceptable2.Text = inaceptable1.Text;
                f4.pobre2.Text = pobre1.Text;
                f4.aceptable2.Text = aceptable1.Text;
                f4.bueno2.Text = bueno1.Text;
                f4.excelente2.Text = excelente1.Text;
                f4.total2.Text = subtotal1.Text;
                f4.Show();
            }
         }

        private void piccerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int total;
            total = Convert.ToInt32(subtotal1.Text);
            //Guardando datos en tabla vacaciones
            listaTrabajadoresBindingSource.EndEdit();
            var detalle = (Trabajador)listaTrabajadoresBindingSource.Current;


            if (total >= 90)
            {
                detalle.Detalle = "Ascenso de Puesto";

            }
            else
            if (total >= 70)
            {
                detalle.Detalle = "Bono";
                detalle.Bono = 1000;
            }
            else
            if (total < 69)
            {
                detalle.Detalle = "Capacitacion";

            }
            _trabajadores.GuardarTrabajador(detalle);
            var resultado = _trabajadores.GuardarTrabajador(detalle);

            if (resultado.Exitoso == true)
            {
                listaTrabajadoresBindingSource.ResetBindings(false);

                DialogResult resul = MessageBox.Show("La personalidad del Empleado se guardado ", "Exitoso...!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }

        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var buscar1 = comboBox2.Text;
            var buscar2 = textBox3.Text;

            listaTrabajadoresBindingSource.DataSource = _trabajadores.ObtenerTrabajador(buscar1, buscar2);

            listaTrabajadoresBindingSource.ResetBindings(false);
            comboBox2.ResetText();
            textBox3.Clear();
        }

        private void Siguiente_Click(object sender, EventArgs e)
        {
            if (comboBox3.SelectedIndex == -1 || comboBox4.SelectedIndex == -1 ||
                comboBox5.SelectedIndex == -1 || comboBox6.SelectedIndex == -1 ||
                comboBox7.SelectedIndex == -1 || comboBox8.SelectedIndex == -1 ||
                comboBox9.SelectedIndex == -1 || comboBox10.SelectedIndex == -1)
            {
                tabControl1.SelectedTab = tabPage1;
                MessageBox.Show("Rellene todos los campos correspondientes");
            }
            if (comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 &&
                comboBox5.SelectedIndex != -1 && comboBox6.SelectedIndex != -1 &&
                comboBox7.SelectedIndex != -1 && comboBox8.SelectedIndex != -1 &&
                comboBox9.SelectedIndex != -1 && comboBox10.SelectedIndex != -1)
            {
                tabControl1.SelectedTab = tabPage2;
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //DATOS PERSONALES
            if (nombreTextBox.Text == "")
            {
                
                tabControl1.SelectedTab = tabPage10;
                MessageBox.Show("Busque un Empleado primero");
            }

            //PAGINA 1
            if (tabControl1.SelectedTab == tabPage2)
            {
                if (comboBox3.SelectedIndex == -1 || comboBox4.SelectedIndex == -1 ||
                    comboBox5.SelectedIndex == -1 || comboBox6.SelectedIndex == -1 ||
                    comboBox7.SelectedIndex == -1 || comboBox8.SelectedIndex == -1 ||
                    comboBox9.SelectedIndex == -1 || comboBox10.SelectedIndex == -1)
                {
                    tabControl1.SelectedTab = tabPage1;
                    MessageBox.Show("Rellene todos los campos correspondientes");
                }
                if (comboBox3.SelectedIndex != -1 && comboBox4.SelectedIndex != -1 &&
                    comboBox5.SelectedIndex != -1 && comboBox6.SelectedIndex != -1 &&
                    comboBox7.SelectedIndex != -1 && comboBox8.SelectedIndex != -1 &&
                    comboBox9.SelectedIndex != -1 && comboBox10.SelectedIndex != -1)
                {
                    tabControl1.SelectedTab = tabPage2;
                }
            }

            //PAGINA 2
            if (tabControl1.SelectedTab == tabPage3)
            {
                if (comboBox11.SelectedIndex == -1 || comboBox12.SelectedIndex == -1 ||
                    comboBox13.SelectedIndex == -1 || comboBox14.SelectedIndex == -1 ||
                    comboBox15.SelectedIndex == -1 || comboBox16.SelectedIndex == -1 ||
                    comboBox17.SelectedIndex == -1 || comboBox18.SelectedIndex == -1)
                {
                    tabControl1.SelectedTab = tabPage2;
                    MessageBox.Show("Rellene todos los campos correspondientes");
                }
                if (comboBox11.SelectedIndex != -1 && comboBox12.SelectedIndex != -1 &&
                    comboBox13.SelectedIndex != -1 && comboBox14.SelectedIndex != -1 &&
                    comboBox15.SelectedIndex != -1 && comboBox16.SelectedIndex != -1 &&
                    comboBox15.SelectedIndex != -1 && comboBox18.SelectedIndex != -1)
                {
                    tabControl1.SelectedTab = tabPage3;
                }
            }

            //Pagina 3
            if (tabControl1.SelectedTab == tabPage4)
            {
                if (comboBox19.SelectedIndex == -1 || comboBox20.SelectedIndex == -1 ||
                    comboBox21.SelectedIndex == -1 || comboBox22.SelectedIndex == -1)
                {
                    tabControl1.SelectedTab = tabPage3;
                    MessageBox.Show("Rellene todos los campos correspondientes");
                }
                if (comboBox19.SelectedIndex != -1 && comboBox20.SelectedIndex != -1 &&
                    comboBox21.SelectedIndex != -1 && comboBox22.SelectedIndex != -1)
                {
                    tabControl1.SelectedTab = tabPage4;
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (comboBox11.SelectedIndex == -1 || comboBox12.SelectedIndex == -1 ||
                comboBox13.SelectedIndex == -1 || comboBox14.SelectedIndex == -1 ||
                comboBox15.SelectedIndex == -1 || comboBox16.SelectedIndex == -1 ||
                comboBox17.SelectedIndex == -1 || comboBox18.SelectedIndex == -1)
            {
                tabControl1.SelectedTab = tabPage2;
                MessageBox.Show("Rellene todos los campos correspondientes");
            }
            if (comboBox11.SelectedIndex != -1 && comboBox12.SelectedIndex != -1 &&
                comboBox13.SelectedIndex != -1 && comboBox14.SelectedIndex != -1 &&
                comboBox15.SelectedIndex != -1 && comboBox16.SelectedIndex != -1 &&
                comboBox15.SelectedIndex != -1 && comboBox18.SelectedIndex != -1)
            {
                tabControl1.SelectedTab = tabPage3;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (comboBox19.SelectedIndex == -1 || comboBox20.SelectedIndex == -1 ||
                comboBox21.SelectedIndex == -1 || comboBox22.SelectedIndex == -1)
            {
                tabControl1.SelectedTab = tabPage3;
                MessageBox.Show("Rellene todos los campos correspondientes");
            }
            if (comboBox19.SelectedIndex != -1 && comboBox20.SelectedIndex != -1 &&
                comboBox21.SelectedIndex != -1 && comboBox22.SelectedIndex != -1)
            {
                tabControl1.SelectedTab = tabPage4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text == "")
            {
                
                tabControl1.SelectedTab = tabPage10;
                MessageBox.Show("Busque un Empleado primero");
            }
            if (nombreTextBox.Text != "")
            {
                tabControl1.SelectedTab = tabPage1;
            }
        }
    }
  }

