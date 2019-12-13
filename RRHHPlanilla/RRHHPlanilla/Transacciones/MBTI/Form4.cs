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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

    
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox17.Text == "I" && textBox18.Text == "N" && textBox19.Text == "F" && textBox20.Text == "P")
            { 
              INFP formulario = new INFP();
            formulario.ShowDialog();
                }
            if (textBox17.Text == "I" && textBox18.Text == "S" && textBox19.Text == "T" && textBox20.Text == "J")
            {
                ISTJ formulario = new ISTJ();
                formulario.ShowDialog();
            }

            if (textBox17.Text == "I" && textBox18.Text == "S" && textBox19.Text == "F" && textBox20.Text == "J")
            {
                ISFJ formulario = new ISFJ();
                formulario.ShowDialog();
            }

            if (textBox17.Text == "I" && textBox18.Text == "N" && textBox19.Text == "F" && textBox20.Text == "J")
            {
                INFJ formulario = new INFJ();
                formulario.ShowDialog();
            }

            if (textBox17.Text == "I" && textBox18.Text == "N" && textBox19.Text == "T" && textBox20.Text == "J")
            {
                INTJ formulario = new INTJ();
                formulario.ShowDialog();
            }
            if (textBox17.Text == "I" && textBox18.Text == "S" && textBox19.Text == "T" && textBox20.Text == "P")
            {
                ISTP formulario = new ISTP();
                formulario.ShowDialog();
            }
            if (textBox17.Text == "I" && textBox18.Text == "S" && textBox19.Text == "F" && textBox20.Text == "P")
            {
                ISFP formulario = new ISFP();
                formulario.ShowDialog();
            }

            if (textBox17.Text == "I" && textBox18.Text == "N" && textBox19.Text == "T" && textBox20.Text == "P")
            {
                INTP formulario = new INTP();
                formulario.ShowDialog();
            }

            if (textBox17.Text == "E" && textBox18.Text == "S" && textBox19.Text == "T" && textBox20.Text == "P")
            {
                ESTP formulario = new ESTP();
                formulario.ShowDialog();
            }

            if (textBox17.Text == "E" && textBox18.Text == "S" && textBox19.Text == "F" && textBox20.Text == "P")
            {
                ESFP formulario = new ESFP();
                formulario.ShowDialog();
            }

            if (textBox17.Text == "E" && textBox18.Text == "N" && textBox19.Text == "F" && textBox20.Text == "P")
            {
                ENFP formulario = new ENFP();
                formulario.ShowDialog();
            }

            if (textBox17.Text == "E" && textBox18.Text == "N" && textBox19.Text == "T" && textBox20.Text == "P")
            {
                ENTP formulario = new ENTP();
                formulario.ShowDialog();
            }

            if (textBox17.Text == "E" && textBox18.Text == "S" && textBox19.Text == "T" && textBox20.Text == "J")
            {
                ESTJ formulario = new ESTJ();
                formulario.ShowDialog();
            }

            if (textBox17.Text == "E" && textBox18.Text == "S" && textBox19.Text == "F" && textBox20.Text == "J")
            {
                ESFJ formulario = new ESFJ();
                formulario.ShowDialog();
            }

            if (textBox17.Text == "E" && textBox18.Text == "N" && textBox19.Text == "T" && textBox20.Text == "J")
            {
                ENTJ formulario = new ENTJ();
                formulario.ShowDialog();
            }

            if (textBox17.Text == "E" && textBox18.Text == "N" && textBox19.Text == "F" && textBox20.Text == "J")
            {
                ENFJ formulario = new ENFJ();
                formulario.ShowDialog();
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
            MBTI formulario = new MBTI();
            formulario.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            info formulario = new info();
            formulario.ShowDialog();
        }

        private void sueldoTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

    }
