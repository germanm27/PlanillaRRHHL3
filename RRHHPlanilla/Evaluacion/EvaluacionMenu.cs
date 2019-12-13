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
        public EvaluacionMenu()
        {
            InitializeComponent();
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

        private void button1_Click(object sender, EventArgs e)
        {
           /*
            ResultadoEva f4 = new ResultadoEva();
            f4.nom4.Text = textBox1.Text;
            f4.ape4.Text = textBox2.Text;
            f4.sex4.Text = comboBox2.Text;
            f4.nacio4.Text = comboBox1.Text;
            f4.direc4.Text = textBox3.Text;
            f4.tele4.Text = empleo1.Text;
            f4.fecha4.Text = dateTimePicker1.Text;
            f4.imgProducto.Text = imgProducto.Text;
            f4.Show();
            this.Hide();     
              */ 
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

        }
        
        private void textBox183_TextChanged(object sender, EventArgs e)
        {

        }

        private void label78_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
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
            //ResultadoEva f4 = new ResultadoEva();
            
            //f4.nom4.Text = textBox1.Text;
            //f4.ape4.Text = textBox2.Text;
            //f4.sex4.Text = comboBox2.Text;
            //f4.nacio4.Text = comboBox1.Text;
            //f4.direc4.Text = textBox3.Text;
            //f4.tele4.Text = empleo1.Text;
            //f4.inaceptable2.Text = inaceptable1.Text;
            //f4.pobre2.Text = pobre1.Text;
            //f4.aceptable2.Text = aceptable1.Text;
            //f4.bueno2.Text = bueno1.Text;
            //f4.excelente2.Text = excelente1.Text;
            //f4.evaluacion2.Text = evaluacion1.Text;
            //f4.fecha5.Text = fecha4.Text;
            //f4.total2.Text = subtotal1.Text;
            //f4.Show();
            //this.Hide();     
            

            } 
        }
           }

