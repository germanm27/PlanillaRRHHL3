using RRHH.BL;
using RRHHPlanilla;
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
    public partial class Form3 : Form
    {
        TrabajadoresBL _trabajadores;
        CargosBL _cargosBL;
        JornadaBL _jornadaBL;
        EstadoCivilBL _estadocivilBL;
        MetodoPagoBL _metodopagoBL;
        SexoBL _sexoBL;

        public Form3()
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
            DeshabilitarHabilitarBotones(true);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox17.Text == "" || textBox18.Text == "" || textBox19.Text == "" || textBox20.Text == "")
            {
                MessageBox.Show("Para continuar realize los calculos");
            }
            else
            {

                Form4 f4 = new Form4();

                f4.idTextBox.Text = idTextBox.Text;
                f4.nombreTextBox.Text = nombreTextBox.Text;
                f4.apellidoTextBox.Text = apellidoTextBox.Text;
                f4.edadTextBox.Text = edadTextBox.Text;
                f4.comboBox1.Text = comboBox1.Text;
                f4.cargoIdComboBox.Text = cargoIdComboBox.Text;
                f4.metodoPagoIdComboBox.Text = metodoPagoIdComboBox.Text;
                f4.jornadaIdComboBox.Text = jornadaIdComboBox.Text;
                f4.fotoPictureBox.Image = fotoPictureBox.Image;
                f4.cedulaTextBox.Text = cedulaTextBox.Text;

                f4.textBox17.Text = textBox17.Text;
                f4.textBox18.Text = textBox18.Text;
                f4.textBox19.Text = textBox19.Text;
                f4.textBox20.Text = textBox20.Text;

                f4.Show();
            }
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

        private void button2_Click(object sender, EventArgs e)
        {

            int a = 0, b = 0, c = 0, d = 0, E = 0, f = 0, g = 0, h = 0, i = 0, j = 0, k = 0, l = 0, m = 0, n = 0, EEt = 0, FFt = 0, IIt = 0, JJt = 0, MMt = 0, NNt = 0;
            if (comboBox72.Text != "A" && comboBox72.Text != "B")
            {
                MessageBox.Show("Realizar la encuetra para poder Calcular");
            }

            else
            {
                #region Suma de campos


                //PRIMERA PARTE
                switch (comboBox3.Text)
                {
                    case "A":
                        a++;
                        textBox28.Text = Convert.ToString(a);
                        break;
                    case "B":
                        b++;
                        textBox36.Text = Convert.ToString(b);
                        break;
                }

                switch (comboBox4.Text)
                {
                    case "A":
                        c++;
                        textBox56.Text = Convert.ToString(c);
                        break;
                    case "B":
                        d++;
                        textBox50.Text = Convert.ToString(d);
                        break;
                }

                switch (comboBox5.Text)
                {
                    case "A":
                        E++;
                        textBox77.Text = Convert.ToString(E);
                        break;
                    case "B":
                        f++;
                        textBox75.Text = Convert.ToString(f);
                        break;
                }
                switch (comboBox6.Text)
                {
                    case "A":
                        g++;
                        textBox97.Text = Convert.ToString(g);
                        break;
                    case "B":
                        h++;
                        textBox95.Text = Convert.ToString(h);
                        break;
                }
                switch (comboBox7.Text)
                {
                    case "A":
                        i++;
                        I1.Text = Convert.ToString(i);
                        break;
                    case "B":
                        j++;
                        J1.Text = Convert.ToString(j);
                        break;
                }
                switch (comboBox8.Text)
                {
                    case "A":
                        k++;
                        K1.Text = Convert.ToString(k);
                        break;
                    case "B":
                        l++;
                        L1.Text = Convert.ToString(l);
                        break;
                }
                switch (comboBox9.Text)
                {
                    case "A":
                        m++;
                        M1.Text = Convert.ToString(m);
                        break;
                    case "B":
                        n++;
                        N1.Text = Convert.ToString(n);
                        break;
                }
                //SEGUNDA PARTE
                switch (comboBox10.Text)
                {
                    case "A":
                        a++;
                        textBox28.Text = Convert.ToString(a);
                        break;
                    case "B":
                        b++;
                        textBox36.Text = Convert.ToString(b);
                        break;
                }

                switch (comboBox11.Text)
                {
                    case "A":
                        c++;
                        textBox56.Text = Convert.ToString(c);
                        break;
                    case "B":
                        d++;
                        textBox50.Text = Convert.ToString(d);
                        break;
                }

                switch (comboBox12.Text)
                {
                    case "A":
                        E++;
                        textBox77.Text = Convert.ToString(E);
                        break;
                    case "B":
                        f++;
                        textBox75.Text = Convert.ToString(f);
                        break;
                }
                switch (comboBox13.Text)
                {
                    case "A":
                        g++;
                        textBox97.Text = Convert.ToString(g);
                        break;
                    case "B":
                        h++;
                        textBox95.Text = Convert.ToString(h);
                        break;
                }
                switch (comboBox14.Text)
                {
                    case "A":
                        i++;
                        I1.Text = Convert.ToString(i);
                        break;
                    case "B":
                        j++;
                        J1.Text = Convert.ToString(j);
                        break;
                }
                switch (comboBox15.Text)
                {
                    case "A":
                        k++;
                        K1.Text = Convert.ToString(k);
                        break;
                    case "B":
                        l++;
                        L1.Text = Convert.ToString(l);
                        break;
                }
                switch (comboBox16.Text)
                {
                    case "A":
                        m++;
                        M1.Text = Convert.ToString(m);
                        break;
                    case "B":
                        n++;
                        N1.Text = Convert.ToString(n);
                        break;
                }
                //TERCERA PARTE
                switch (comboBox17.Text)
                {
                    case "A":
                        a++;
                        textBox28.Text = Convert.ToString(a);
                        break;
                    case "B":
                        b++;
                        textBox36.Text = Convert.ToString(b);
                        break;
                }

                switch (comboBox18.Text)
                {
                    case "A":
                        c++;
                        textBox56.Text = Convert.ToString(c);
                        break;
                    case "B":
                        d++;
                        textBox50.Text = Convert.ToString(d);
                        break;
                }

                switch (comboBox19.Text)
                {
                    case "A":
                        E++;
                        textBox77.Text = Convert.ToString(E);
                        break;
                    case "B":
                        f++;
                        textBox75.Text = Convert.ToString(f);
                        break;
                }
                switch (comboBox20.Text)
                {
                    case "A":
                        g++;
                        textBox97.Text = Convert.ToString(g);
                        break;
                    case "B":
                        h++;
                        textBox95.Text = Convert.ToString(h);
                        break;
                }
                switch (comboBox21.Text)
                {
                    case "A":
                        i++;
                        I1.Text = Convert.ToString(i);
                        break;
                    case "B":
                        j++;
                        J1.Text = Convert.ToString(j);
                        break;
                }
                switch (comboBox22.Text)
                {
                    case "A":
                        k++;
                        K1.Text = Convert.ToString(k);
                        break;
                    case "B":
                        l++;
                        L1.Text = Convert.ToString(l);
                        break;
                }
                switch (comboBox23.Text)
                {
                    case "A":
                        m++;
                        M1.Text = Convert.ToString(m);
                        break;
                    case "B":
                        n++;
                        N1.Text = Convert.ToString(n);
                        break;
                }
                //CUARTA PARTE
                switch (comboBox24.Text)
                {
                    case "A":
                        a++;
                        textBox28.Text = Convert.ToString(a);
                        break;
                    case "B":
                        b++;
                        textBox36.Text = Convert.ToString(b);
                        break;
                }

                switch (comboBox25.Text)
                {
                    case "A":
                        c++;
                        textBox56.Text = Convert.ToString(c);
                        break;
                    case "B":
                        d++;
                        textBox50.Text = Convert.ToString(d);
                        break;
                }

                switch (comboBox26.Text)
                {
                    case "A":
                        E++;
                        textBox77.Text = Convert.ToString(E);
                        break;
                    case "B":
                        f++;
                        textBox75.Text = Convert.ToString(f);
                        break;
                }
                switch (comboBox27.Text)
                {
                    case "A":
                        g++;
                        textBox97.Text = Convert.ToString(g);
                        break;
                    case "B":
                        h++;
                        textBox95.Text = Convert.ToString(h);
                        break;
                }
                switch (comboBox28.Text)
                {
                    case "A":
                        i++;
                        I1.Text = Convert.ToString(i);
                        break;
                    case "B":
                        j++;
                        J1.Text = Convert.ToString(j);
                        break;
                }
                switch (comboBox29.Text)
                {
                    case "A":
                        k++;
                        K1.Text = Convert.ToString(k);
                        break;
                    case "B":
                        l++;
                        L1.Text = Convert.ToString(l);
                        break;
                }
                switch (comboBox30.Text)
                {
                    case "A":
                        m++;
                        M1.Text = Convert.ToString(m);
                        break;
                    case "B":
                        n++;
                        N1.Text = Convert.ToString(n);
                        break;
                }
                //QUINTA PARTE
                switch (comboBox31.Text)
                {
                    case "A":
                        a++;
                        textBox28.Text = Convert.ToString(a);
                        break;
                    case "B":
                        b++;
                        textBox36.Text = Convert.ToString(b);
                        break;
                }

                switch (comboBox32.Text)
                {
                    case "A":
                        c++;
                        textBox56.Text = Convert.ToString(c);
                        break;
                    case "B":
                        d++;
                        textBox50.Text = Convert.ToString(d);
                        break;
                }

                switch (comboBox33.Text)
                {
                    case "A":
                        E++;
                        textBox77.Text = Convert.ToString(E);
                        break;
                    case "B":
                        f++;
                        textBox75.Text = Convert.ToString(f);
                        break;
                }
                switch (comboBox34.Text)
                {
                    case "A":
                        g++;
                        textBox97.Text = Convert.ToString(g);
                        break;
                    case "B":
                        h++;
                        textBox95.Text = Convert.ToString(h);
                        break;
                }
                switch (comboBox35.Text)
                {
                    case "A":
                        i++;
                        I1.Text = Convert.ToString(i);
                        break;
                    case "B":
                        j++;
                        J1.Text = Convert.ToString(j);
                        break;
                }
                switch (comboBox36.Text)
                {
                    case "A":
                        k++;
                        K1.Text = Convert.ToString(k);
                        break;
                    case "B":
                        l++;
                        L1.Text = Convert.ToString(l);
                        break;
                }
                switch (comboBox37.Text)
                {
                    case "A":
                        m++;
                        M1.Text = Convert.ToString(m);
                        break;
                    case "B":
                        n++;
                        N1.Text = Convert.ToString(n);
                        break;
                }
                //SEXTA PARTE
                switch (comboBox38.Text)
                {
                    case "A":
                        a++;
                        textBox28.Text = Convert.ToString(a);
                        break;
                    case "B":
                        b++;
                        textBox36.Text = Convert.ToString(b);
                        break;
                }

                switch (comboBox39.Text)
                {
                    case "A":
                        c++;
                        textBox56.Text = Convert.ToString(c);
                        break;
                    case "B":
                        d++;
                        textBox50.Text = Convert.ToString(d);
                        break;
                }

                switch (comboBox40.Text)
                {
                    case "A":
                        E++;
                        textBox77.Text = Convert.ToString(E);
                        break;
                    case "B":
                        f++;
                        textBox75.Text = Convert.ToString(f);
                        break;
                }
                switch (comboBox41.Text)
                {
                    case "A":
                        g++;
                        textBox97.Text = Convert.ToString(g);
                        break;
                    case "B":
                        h++;
                        textBox95.Text = Convert.ToString(h);
                        break;
                }
                switch (comboBox42.Text)
                {
                    case "A":
                        i++;
                        I1.Text = Convert.ToString(i);
                        break;
                    case "B":
                        j++;
                        J1.Text = Convert.ToString(j);
                        break;
                }
                switch (comboBox43.Text)
                {
                    case "A":
                        k++;
                        K1.Text = Convert.ToString(k);
                        break;
                    case "B":
                        l++;
                        L1.Text = Convert.ToString(l);
                        break;
                }
                switch (comboBox44.Text)
                {
                    case "A":
                        m++;
                        M1.Text = Convert.ToString(m);
                        break;
                    case "B":
                        n++;
                        N1.Text = Convert.ToString(n);
                        break;
                }
                //SEPTIMA PARTE
                switch (comboBox45.Text)
                {
                    case "A":
                        a++;
                        textBox28.Text = Convert.ToString(a);
                        break;
                    case "B":
                        b++;
                        textBox36.Text = Convert.ToString(b);
                        break;
                }

                switch (comboBox46.Text)
                {
                    case "A":
                        c++;
                        textBox56.Text = Convert.ToString(c);
                        break;
                    case "B":
                        d++;
                        textBox50.Text = Convert.ToString(d);
                        break;
                }

                switch (comboBox47.Text)
                {
                    case "A":
                        E++;
                        textBox77.Text = Convert.ToString(E);
                        break;
                    case "B":
                        f++;
                        textBox75.Text = Convert.ToString(f);
                        break;
                }
                switch (comboBox48.Text)
                {
                    case "A":
                        g++;
                        textBox97.Text = Convert.ToString(g);
                        break;
                    case "B":
                        h++;
                        textBox95.Text = Convert.ToString(h);
                        break;
                }
                switch (comboBox49.Text)
                {
                    case "A":
                        i++;
                        I1.Text = Convert.ToString(i);
                        break;
                    case "B":
                        j++;
                        J1.Text = Convert.ToString(j);
                        break;
                }
                switch (comboBox50.Text)
                {
                    case "A":
                        k++;
                        K1.Text = Convert.ToString(k);
                        break;
                    case "B":
                        l++;
                        L1.Text = Convert.ToString(l);
                        break;
                }
                switch (comboBox51.Text)
                {
                    case "A":
                        m++;
                        M1.Text = Convert.ToString(m);
                        break;
                    case "B":
                        n++;
                        N1.Text = Convert.ToString(n);
                        break;
                }
                //OCTAVA PARTE
                switch (comboBox52.Text)
                {
                    case "A":
                        a++;
                        textBox28.Text = Convert.ToString(a);
                        break;
                    case "B":
                        b++;
                        textBox36.Text = Convert.ToString(b);
                        break;
                }

                switch (comboBox53.Text)
                {
                    case "A":
                        c++;
                        textBox56.Text = Convert.ToString(c);
                        break;
                    case "B":
                        d++;
                        textBox50.Text = Convert.ToString(d);
                        break;
                }

                switch (comboBox54.Text)
                {
                    case "A":
                        E++;
                        textBox77.Text = Convert.ToString(E);
                        break;
                    case "B":
                        f++;
                        textBox75.Text = Convert.ToString(f);
                        break;
                }
                switch (comboBox55.Text)
                {
                    case "A":
                        g++;
                        textBox97.Text = Convert.ToString(g);
                        break;
                    case "B":
                        h++;
                        textBox95.Text = Convert.ToString(h);
                        break;
                }
                switch (comboBox56.Text)
                {
                    case "A":
                        i++;
                        I1.Text = Convert.ToString(i);
                        break;
                    case "B":
                        j++;
                        J1.Text = Convert.ToString(j);
                        break;
                }
                switch (comboBox57.Text)
                {
                    case "A":
                        k++;
                        K1.Text = Convert.ToString(k);
                        break;
                    case "B":
                        l++;
                        L1.Text = Convert.ToString(l);
                        break;
                }
                switch (comboBox58.Text)
                {
                    case "A":
                        m++;
                        M1.Text = Convert.ToString(m);
                        break;
                    case "B":
                        n++;
                        N1.Text = Convert.ToString(n);
                        break;
                }
                //NOVENA PARTE

                switch (comboBox59.Text)
                {
                    case "A":
                        a++;
                        textBox28.Text = Convert.ToString(a);
                        break;
                    case "B":
                        b++;
                        textBox36.Text = Convert.ToString(b);
                        break;
                }

                switch (comboBox60.Text)
                {
                    case "A":
                        c++;
                        textBox56.Text = Convert.ToString(c);
                        break;
                    case "B":
                        d++;
                        textBox50.Text = Convert.ToString(d);
                        break;
                }

                switch (comboBox61.Text)
                {
                    case "A":
                        E++;
                        textBox77.Text = Convert.ToString(E);
                        break;
                    case "B":
                        f++;
                        textBox75.Text = Convert.ToString(f);
                        break;
                }
                switch (comboBox62.Text)
                {
                    case "A":
                        g++;
                        textBox97.Text = Convert.ToString(g);
                        break;
                    case "B":
                        h++;
                        textBox95.Text = Convert.ToString(h);
                        break;
                }
                switch (comboBox63.Text)
                {
                    case "A":
                        i++;
                        I1.Text = Convert.ToString(i);
                        break;
                    case "B":
                        j++;
                        J1.Text = Convert.ToString(j);
                        break;
                }
                switch (comboBox64.Text)
                {
                    case "A":
                        k++;
                        K1.Text = Convert.ToString(k);
                        break;
                    case "B":
                        l++;
                        L1.Text = Convert.ToString(l);
                        break;
                }
                switch (comboBox65.Text)
                {
                    case "A":
                        m++;
                        M1.Text = Convert.ToString(m);
                        break;
                    case "B":
                        n++;
                        N1.Text = Convert.ToString(n);
                        break;
                }
                //DECIMA PARTE
                switch (comboBox66.Text)
                {
                    case "A":
                        a++;
                        textBox28.Text = Convert.ToString(a);
                        break;
                    case "B":
                        b++;
                        textBox36.Text = Convert.ToString(b);
                        break;
                }

                switch (comboBox67.Text)
                {
                    case "A":
                        c++;
                        textBox56.Text = Convert.ToString(c);
                        break;
                    case "B":
                        d++;
                        textBox50.Text = Convert.ToString(d);
                        break;
                }

                switch (comboBox68.Text)
                {
                    case "A":
                        E++;
                        textBox77.Text = Convert.ToString(E);
                        break;
                    case "B":
                        f++;
                        textBox75.Text = Convert.ToString(f);
                        break;
                }
                switch (comboBox69.Text)
                {
                    case "A":
                        g++;
                        textBox97.Text = Convert.ToString(g);
                        break;
                    case "B":
                        h++;
                        textBox95.Text = Convert.ToString(h);
                        break;
                }
                switch (comboBox70.Text)
                {
                    case "A":
                        i++;
                        I1.Text = Convert.ToString(i);
                        break;
                    case "B":
                        j++;
                        J1.Text = Convert.ToString(j);
                        break;
                }
                switch (comboBox71.Text)
                {
                    case "A":
                        k++;
                        K1.Text = Convert.ToString(k);
                        break;
                    case "B":
                        l++;
                        L1.Text = Convert.ToString(l);
                        break;
                }
                switch (comboBox72.Text)
                {
                    case "A":
                        m++;
                        M1.Text = Convert.ToString(m);
                        break;
                    case "B":
                        n++;
                        N1.Text = Convert.ToString(n);
                        break;
                }

                //suma de campos
                EEt = c + E;
                FFt = d + f;
                IIt = g + i;
                JJt = h + j;
                MMt = k + m;
                NNt = l + n;

                EET.Text = Convert.ToString(EEt);
                FFT.Text = Convert.ToString(FFt);
                IIT.Text = Convert.ToString(IIt);
                JJT.Text = Convert.ToString(JJt);
                MMT.Text = Convert.ToString(MMt);
                NNT.Text = Convert.ToString(NNt);

                AT.Text = Convert.ToString(a);
                BT.Text = Convert.ToString(b);
                CT.Text = Convert.ToString(c);
                DT.Text = Convert.ToString(d);
                ET.Text = Convert.ToString(E);
                FT.Text = Convert.ToString(f);
                GT.Text = Convert.ToString(g);
                HT.Text = Convert.ToString(h);
                IT.Text = Convert.ToString(i);
                JT.Text = Convert.ToString(j);
                KT.Text = Convert.ToString(k);
                LT.Text = Convert.ToString(l);
                MT.Text = Convert.ToString(m);
                NT.Text = Convert.ToString(n);

                //CALCULO PARA SACAR LAS LETRAS
                if (a > b)
                {
                    textBox5.Text = "E";
                    textBox13.Text = "E";
                }

                else
                {
                    textBox6.Text = "I";
                    textBox13.Text = "I";
                }

                if (EEt > FFt)
                {
                    textBox7.Text = "S";
                    textBox14.Text = "S";
                }
                else
                {
                    textBox8.Text = "N";
                    textBox14.Text = "N";
                }

                if (IIt > JJt)
                {
                    textBox9.Text = "T";
                    textBox15.Text = "T";
                }

                else
                {
                    textBox10.Text = "F";
                    textBox15.Text = "F";
                }

                if (MMt > NNt)
                {
                    textBox11.Text = "J";
                    textBox16.Text = "J";
                }
                else
                {
                    textBox12.Text = "P";
                    textBox16.Text = "P";
                }

                //PASAR A CAMPO DE PERSONALIDAD
                textBox17.Text = textBox13.Text;
                textBox18.Text = textBox14.Text;
                textBox19.Text = textBox15.Text;
                textBox20.Text = textBox16.Text;
                #endregion

            }
        }

        private void textBox183_TextChanged(object sender, EventArgs e)
        {

        }

        private void label78_Click(object sender, EventArgs e)
        {

        }

        private void imgProducto_Click(object sender, EventArgs e)
        {

        }

        private void piccerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage10_Click(object sender, EventArgs e)
        {

        }

        private void label110_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //Guardando datos en tabla vacaciones
            listaTrabajadoresBindingSource.EndEdit();
            var personalidad = (Trabajador)listaTrabajadoresBindingSource.Current;
            #region Personalidades

            if (textBox17.Text == "I" && textBox18.Text == "N" && textBox19.Text == "F" && textBox20.Text == "P")
            {


                personalidad.Personalidad = "INFP";

            }
            if (textBox17.Text == "I" && textBox18.Text == "S" && textBox19.Text == "T" && textBox20.Text == "J")
            {


                personalidad.Personalidad = "ISTJ";

            }

            if (textBox17.Text == "I" && textBox18.Text == "S" && textBox19.Text == "F" && textBox20.Text == "J")
            {


                personalidad.Personalidad = "ISFJ";

            }

            if (textBox17.Text == "I" && textBox18.Text == "N" && textBox19.Text == "F" && textBox20.Text == "J")
            {


                personalidad.Personalidad = "INFJ";

            }

            if (textBox17.Text == "I" && textBox18.Text == "N" && textBox19.Text == "T" && textBox20.Text == "J")
            {


                personalidad.Personalidad = "INTJ";

            }
            if (textBox17.Text == "I" && textBox18.Text == "S" && textBox19.Text == "T" && textBox20.Text == "P")
            {


                personalidad.Personalidad = "ISTP";

            }
            if (textBox17.Text == "I" && textBox18.Text == "S" && textBox19.Text == "F" && textBox20.Text == "P")
            {


                personalidad.Personalidad = "ISFP";

            }

            if (textBox17.Text == "I" && textBox18.Text == "N" && textBox19.Text == "T" && textBox20.Text == "P")
            {


                personalidad.Personalidad = "INTP";

            }

            if (textBox17.Text == "E" && textBox18.Text == "S" && textBox19.Text == "T" && textBox20.Text == "P")
            {


                personalidad.Personalidad = "ESTP";

            }

            if (textBox17.Text == "E" && textBox18.Text == "S" && textBox19.Text == "F" && textBox20.Text == "P")
            {


                personalidad.Personalidad = "ESFP";

            }

            if (textBox17.Text == "E" && textBox18.Text == "N" && textBox19.Text == "F" && textBox20.Text == "P")
            {


                personalidad.Personalidad = "ENFP";

            }

            if (textBox17.Text == "E" && textBox18.Text == "N" && textBox19.Text == "T" && textBox20.Text == "P")
            {


                personalidad.Personalidad = "ENTP";

            }

            if (textBox17.Text == "E" && textBox18.Text == "S" && textBox19.Text == "T" && textBox20.Text == "J")
            {


                personalidad.Personalidad = "ESTJ";

            }

            if (textBox17.Text == "E" && textBox18.Text == "S" && textBox19.Text == "F" && textBox20.Text == "J")
            {


                personalidad.Personalidad = "ESFJ";

            }

            if (textBox17.Text == "E" && textBox18.Text == "N" && textBox19.Text == "T" && textBox20.Text == "J")
            {

                personalidad.Personalidad = "ENTJ";

            }

            if (textBox17.Text == "E" && textBox18.Text == "N" && textBox19.Text == "F" && textBox20.Text == "J")
            {


                personalidad.Personalidad = "ENFJ";

            }
            #endregion

            _trabajadores.GuardarTrabajador(personalidad);
            var resultado = _trabajadores.GuardarTrabajador(personalidad);

            if (textBox20.Text == "")
            {
                MessageBox.Show("Realize el Calculo para Guardar los cambios");

            }

            else
            {
                if (resultado.Exitoso == true)
                {
                    listaTrabajadoresBindingSource.ResetBindings(false);

                    DialogResult resul = MessageBox.Show("La Evaluacion del Empleado se guardado ", "Exitoso...!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show(resultado.Mensaje);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var buscar1 = comboBox2.Text;
            var buscar2 = textBox3.Text;

            listaTrabajadoresBindingSource.DataSource = _trabajadores.ObtenerTrabajador(buscar1, buscar2);

            listaTrabajadoresBindingSource.ResetBindings(false);
            comboBox2.ResetText();
            textBox3.Clear();

            if (idTextBox.Text == "")
            {
                MessageBox.Show("Empleado no Existe Intentelo de nuevo");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (nombreTextBox.Text == "" && apellidoTextBox.Text == "")
            {
                tabControl1.SelectedTab = tabPage10;
                MessageBox.Show("Busque un Empleado primero");
            }

            if (nombreTextBox.Text != "")
            {
                tabControl1.SelectedTab = tabPage1;
            }
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
               comboBox21.SelectedIndex == -1 || comboBox22.SelectedIndex == -1 || comboBox23.SelectedIndex == -1
               || comboBox24.SelectedIndex == -1 || comboBox25.SelectedIndex == -1 || comboBox26.SelectedIndex == -1)
            {
                tabControl1.SelectedTab = tabPage3;
                MessageBox.Show("Rellene todos los campos correspondientes");
            }
            if (comboBox19.SelectedIndex != -1 && comboBox20.SelectedIndex != -1 &&
                comboBox21.SelectedIndex != -1 && comboBox22.SelectedIndex != -1 && comboBox23.SelectedIndex != -1
                && comboBox24.SelectedIndex != -1 && comboBox25.SelectedIndex != -1 && comboBox26.SelectedIndex != -1)
            {
                tabControl1.SelectedTab = tabPage4;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (comboBox27.SelectedIndex == -1 || comboBox28.SelectedIndex == -1 ||
               comboBox29.SelectedIndex == -1 || comboBox30.SelectedIndex == -1 || comboBox31.SelectedIndex == -1
               || comboBox32.SelectedIndex == -1 || comboBox33.SelectedIndex == -1 || comboBox34.SelectedIndex == -1)
            {
                tabControl1.SelectedTab = tabPage4;
                MessageBox.Show("Rellene todos los campos correspondientes");
            }
            if (comboBox27.SelectedIndex != -1 && comboBox28.SelectedIndex != -1 &&
                comboBox29.SelectedIndex != -1 && comboBox30.SelectedIndex != -1 && comboBox31.SelectedIndex != -1
                && comboBox32.SelectedIndex != -1 && comboBox33.SelectedIndex != -1 && comboBox34.SelectedIndex != -1)
            {
                tabControl1.SelectedTab = tabPage5;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox35.SelectedIndex == -1 || comboBox36.SelectedIndex == -1 ||
                comboBox37.SelectedIndex == -1 || comboBox38.SelectedIndex == -1 ||
                comboBox39.SelectedIndex == -1 || comboBox40.SelectedIndex == -1 ||
                comboBox41.SelectedIndex == -1 || comboBox42.SelectedIndex == -1)
            {
                tabControl1.SelectedTab = tabPage5;
                MessageBox.Show("Rellene todos los campos correspondientes");
            }
            if (comboBox35.SelectedIndex != -1 && comboBox36.SelectedIndex != -1 &&
                comboBox37.SelectedIndex != -1 && comboBox38.SelectedIndex != -1 && comboBox39.SelectedIndex != -1
                && comboBox40.SelectedIndex != -1 && comboBox41.SelectedIndex != -1 && comboBox42.SelectedIndex != -1)
            {
                tabControl1.SelectedTab = tabPage6;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (comboBox43.SelectedIndex == -1 || comboBox44.SelectedIndex == -1 ||
                comboBox45.SelectedIndex == -1 || comboBox46.SelectedIndex == -1 ||
                comboBox47.SelectedIndex == -1 || comboBox48.SelectedIndex == -1 ||
                comboBox49.SelectedIndex == -1 || comboBox50.SelectedIndex == -1)
            {
                tabControl1.SelectedTab = tabPage6;
                MessageBox.Show("Rellene todos los campos correspondientes");
            }
            if (comboBox43.SelectedIndex != -1 && comboBox44.SelectedIndex != -1 &&
                comboBox45.SelectedIndex != -1 && comboBox46.SelectedIndex != -1 && comboBox47.SelectedIndex != -1
                && comboBox48.SelectedIndex != -1 && comboBox49.SelectedIndex != -1 && comboBox50.SelectedIndex != -1)
            {
                tabControl1.SelectedTab = tabPage7;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (comboBox51.SelectedIndex == -1 || comboBox52.SelectedIndex == -1 ||
                comboBox53.SelectedIndex == -1 || comboBox54.SelectedIndex == -1 ||
                comboBox55.SelectedIndex == -1 || comboBox56.SelectedIndex == -1 ||
                comboBox57.SelectedIndex == -1 || comboBox58.SelectedIndex == -1)
            {
                tabControl1.SelectedTab = tabPage7;
                MessageBox.Show("Rellene todos los campos correspondientes");
            }
            if (comboBox51.SelectedIndex != -1 && comboBox52.SelectedIndex != -1 &&
                comboBox53.SelectedIndex != -1 && comboBox54.SelectedIndex != -1 && comboBox55.SelectedIndex != -1
                && comboBox56.SelectedIndex != -1 && comboBox57.SelectedIndex != -1 && comboBox58.SelectedIndex != -1)
            {
                tabControl1.SelectedTab = tabPage8;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (comboBox59.SelectedIndex == -1 || comboBox60.SelectedIndex == -1 ||
                comboBox61.SelectedIndex == -1 || comboBox62.SelectedIndex == -1 ||
                comboBox63.SelectedIndex == -1 || comboBox64.SelectedIndex == -1 ||
                comboBox65.SelectedIndex == -1 || comboBox66.SelectedIndex == -1)
            {
                tabControl1.SelectedTab = tabPage8;
                MessageBox.Show("Rellene todos los campos correspondientes");
            }
            if (comboBox59.SelectedIndex != -1 && comboBox60.SelectedIndex != -1 &&
                comboBox61.SelectedIndex != -1 && comboBox62.SelectedIndex != -1 && comboBox63.SelectedIndex != -1
                && comboBox64.SelectedIndex != -1 && comboBox65.SelectedIndex != -1 && comboBox66.SelectedIndex != -1)
            {
                tabControl1.SelectedTab = tabPage9;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (comboBox67.SelectedIndex == -1 || comboBox68.SelectedIndex == -1 ||
                comboBox69.SelectedIndex == -1 || comboBox70.SelectedIndex == -1 ||
                comboBox71.SelectedIndex == -1 || comboBox72.SelectedIndex == -1)
            {
                tabControl1.SelectedTab = tabPage9;
                MessageBox.Show("Rellene todos los campos correspondientes");
            }
            if (comboBox67.SelectedIndex != -1 && comboBox68.SelectedIndex != -1 &&
                comboBox69.SelectedIndex != -1 && comboBox70.SelectedIndex != -1 && comboBox71.SelectedIndex != -1
                && comboBox72.SelectedIndex != -1)
            {
                tabControl1.SelectedTab = tabPage11;
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

            //PAGINA 3
            if (tabControl1.SelectedTab == tabPage4)
            {
                if (comboBox19.SelectedIndex == -1 || comboBox20.SelectedIndex == -1 ||
             comboBox21.SelectedIndex == -1 || comboBox22.SelectedIndex == -1 || comboBox23.SelectedIndex == -1
             || comboBox24.SelectedIndex == -1 || comboBox25.SelectedIndex == -1 || comboBox26.SelectedIndex == -1)
                {
                    tabControl1.SelectedTab = tabPage3;
                    MessageBox.Show("Rellene todos los campos correspondientes");
                }
                if (comboBox19.SelectedIndex != -1 && comboBox20.SelectedIndex != -1 &&
                    comboBox21.SelectedIndex != -1 && comboBox22.SelectedIndex != -1 && comboBox23.SelectedIndex != -1
                    && comboBox24.SelectedIndex != -1 && comboBox25.SelectedIndex != -1 && comboBox26.SelectedIndex != -1)
                {
                    tabControl1.SelectedTab = tabPage4;
                }
            }


            //PAGINA 4
            if (tabControl1.SelectedTab == tabPage5)
            {
                if (comboBox27.SelectedIndex == -1 || comboBox28.SelectedIndex == -1 ||
                 comboBox29.SelectedIndex == -1 || comboBox30.SelectedIndex == -1 || comboBox31.SelectedIndex == -1
                 || comboBox32.SelectedIndex == -1 || comboBox33.SelectedIndex == -1 || comboBox34.SelectedIndex == -1)
                {
                    tabControl1.SelectedTab = tabPage4;
                    MessageBox.Show("Rellene todos los campos correspondientes");
                }
                if (comboBox27.SelectedIndex != -1 && comboBox28.SelectedIndex != -1 &&
                    comboBox29.SelectedIndex != -1 && comboBox30.SelectedIndex != -1 && comboBox31.SelectedIndex != -1
                    && comboBox32.SelectedIndex != -1 && comboBox33.SelectedIndex != -1 && comboBox34.SelectedIndex != -1)
                {
                    tabControl1.SelectedTab = tabPage5;
                }
            }


            //PAGINA 5
            if (tabControl1.SelectedTab == tabPage6)
            {
                if (comboBox35.SelectedIndex == -1 || comboBox36.SelectedIndex == -1 ||
              comboBox37.SelectedIndex == -1 || comboBox38.SelectedIndex == -1 ||
              comboBox39.SelectedIndex == -1 || comboBox40.SelectedIndex == -1 ||
              comboBox41.SelectedIndex == -1 || comboBox42.SelectedIndex == -1)
                {
                    tabControl1.SelectedTab = tabPage5;
                    MessageBox.Show("Rellene todos los campos correspondientes");
                }
                if (comboBox35.SelectedIndex != -1 && comboBox36.SelectedIndex != -1 &&
                    comboBox37.SelectedIndex != -1 && comboBox38.SelectedIndex != -1 && comboBox39.SelectedIndex != -1
                    && comboBox40.SelectedIndex != -1 && comboBox41.SelectedIndex != -1 && comboBox42.SelectedIndex != -1)
                {
                    tabControl1.SelectedTab = tabPage6;
                }
            }

            //PAGINA 6
            if (tabControl1.SelectedTab == tabPage7)
            {
                if (comboBox43.SelectedIndex == -1 || comboBox44.SelectedIndex == -1 ||
                  comboBox45.SelectedIndex == -1 || comboBox46.SelectedIndex == -1 ||
                  comboBox47.SelectedIndex == -1 || comboBox48.SelectedIndex == -1 ||
                  comboBox49.SelectedIndex == -1 || comboBox50.SelectedIndex == -1)
                {
                    tabControl1.SelectedTab = tabPage6;
                    MessageBox.Show("Rellene todos los campos correspondientes");
                }
                if (comboBox43.SelectedIndex != -1 && comboBox44.SelectedIndex != -1 &&
                    comboBox45.SelectedIndex != -1 && comboBox46.SelectedIndex != -1 && comboBox47.SelectedIndex != -1
                    && comboBox48.SelectedIndex != -1 && comboBox49.SelectedIndex != -1 && comboBox50.SelectedIndex != -1)
                {
                    tabControl1.SelectedTab = tabPage7;
                }
            }

            //PAGINA 7
            if (tabControl1.SelectedTab == tabPage8)
            {
                if (comboBox51.SelectedIndex == -1 || comboBox52.SelectedIndex == -1 ||
               comboBox53.SelectedIndex == -1 || comboBox54.SelectedIndex == -1 ||
               comboBox55.SelectedIndex == -1 || comboBox56.SelectedIndex == -1 ||
               comboBox57.SelectedIndex == -1 || comboBox58.SelectedIndex == -1)
                {
                    tabControl1.SelectedTab = tabPage7;
                    MessageBox.Show("Rellene todos los campos correspondientes");
                }
                if (comboBox51.SelectedIndex != -1 && comboBox52.SelectedIndex != -1 &&
                    comboBox53.SelectedIndex != -1 && comboBox54.SelectedIndex != -1 && comboBox55.SelectedIndex != -1
                    && comboBox56.SelectedIndex != -1 && comboBox57.SelectedIndex != -1 && comboBox58.SelectedIndex != -1)
                {
                    tabControl1.SelectedTab = tabPage8;
                }
            }


            //PAGINA 8
            if (tabControl1.SelectedTab == tabPage9)
            {
                if (comboBox59.SelectedIndex == -1 || comboBox60.SelectedIndex == -1 ||
                  comboBox61.SelectedIndex == -1 || comboBox62.SelectedIndex == -1 ||
                  comboBox63.SelectedIndex == -1 || comboBox64.SelectedIndex == -1 ||
                  comboBox65.SelectedIndex == -1 || comboBox66.SelectedIndex == -1)
                {
                    tabControl1.SelectedTab = tabPage8;
                    MessageBox.Show("Rellene todos los campos correspondientes");
                }
                if (comboBox59.SelectedIndex != -1 && comboBox60.SelectedIndex != -1 &&
                    comboBox61.SelectedIndex != -1 && comboBox62.SelectedIndex != -1 && comboBox63.SelectedIndex != -1
                    && comboBox64.SelectedIndex != -1 && comboBox65.SelectedIndex != -1 && comboBox66.SelectedIndex != -1)
                {
                    tabControl1.SelectedTab = tabPage9;
                }
            }

            //PAGINA 9
            if (tabControl1.SelectedTab == tabPage11)
            {
                if (comboBox67.SelectedIndex == -1 || comboBox68.SelectedIndex == -1 ||
                 comboBox69.SelectedIndex == -1 || comboBox70.SelectedIndex == -1 ||
                 comboBox71.SelectedIndex == -1 || comboBox72.SelectedIndex == -1)
                {
                    tabControl1.SelectedTab = tabPage9;
                    MessageBox.Show("Rellene todos los campos correspondientes");
                }
                if (comboBox67.SelectedIndex != -1 && comboBox68.SelectedIndex != -1 &&
                    comboBox69.SelectedIndex != -1 && comboBox70.SelectedIndex != -1 && comboBox71.SelectedIndex != -1
                    && comboBox72.SelectedIndex != -1)
                {
                    tabControl1.SelectedTab = tabPage11;
                }
            }

        }
    }
}
    
    
    

