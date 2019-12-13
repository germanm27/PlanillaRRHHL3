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
    public partial class ResultadoEva : Form
    {
        public ResultadoEva()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

         private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void ResultadoEva_Load(object sender, EventArgs e)
        {

        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            int total;
            total = Convert.ToInt16(total2.Text);

            if (total >= 90)
            {
                MessageBox.Show("Se Recomienda un Ascenso de Puesto por Excelente Desempeño", "Excelente Desempeño", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
            else 
            if (total >= 70)
            {
                MessageBox.Show("Se Recomienda un Bono por Buen Desempeño", "Aceptable Desempeño", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else 
            if (total < 69)
            {
                MessageBox.Show("Se Recomienda Capacitacion por un Pobre Desempeño", "Pobre Desempeño", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            info formulario = new info();
            formulario.ShowDialog();
        }

       

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
                    }
    }

    }
