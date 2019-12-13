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
    public partial class Busquedas : Form
    {
        CargosBL _cargosBL;
        TrabajadoresBL _trabajoresBL;
        public Busquedas()
        {
            InitializeComponent();


            _cargosBL = new CargosBL();
            listaCargosBindingSource.DataSource = _cargosBL.ObtenerCargos();

            _trabajoresBL = new TrabajadoresBL();
            listaTrabajadoresBindingSource.DataSource = _trabajoresBL.ObtenerTrabajador();
        }

        BusquedaBL sql = new BusquedaBL();
        private void dvg_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filas = dataGridView1.Rows[e.RowIndex];
            //textBox1.Text = Convert.ToString(filas.Cells[0].Value);
            //textBox2.Text = Convert.ToString(filas.Cells[2].Value);
            //textBox3.Text = Convert.ToString(filas.Cells[3].Value);
        }

        private void Busquedas_Load(object sender, EventArgs e)
        {
            cargoIdComboBox.SelectedItem = null;
            dataGridView1.DataSource = sql.MostrarDatos();
            //dataGridView1.DataSource = _cargosBL.ObtenerCargos();

            //DataGridViewColumn Column1 = dataGridView1.Columns[1];
            //Column1.Visible = false;

            //DataGridViewColumn Column8 = dataGridView1.Columns[8];
            //Column8.Visible = false;

            //DataGridViewColumn Column9 = dataGridView1.Columns[9];
            //Column9.Visible = true;

            //DataGridViewColumn Column10 = dataGridView1.Columns[10];
            //Column10.Visible = false;

            //DataGridViewColumn Column11 = dataGridView1.Columns[11];
            //Column11.Visible = false;

            //DataGridViewColumn Column12 = dataGridView1.Columns[12];
            //Column12.Visible = false;
        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {
            
            if (textBox4.Text != "")
            {
                cargoIdComboBox.SelectedItem = null;
                dataGridView1.DataSource = sql.Buscar(textBox4.Text, textBox4.Text);
            }
            else
            {
                dataGridView1.DataSource = sql.MostrarDatos();
            }
        }

        private void cargoIdComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cargoIdComboBox.Text != "")
            {
                dataGridView1.DataSource = sql.Buscar2(cargoIdComboBox.Text);
            }
            else
            {
                dataGridView1.DataSource = sql.MostrarDatos();
            }
        }

        private void piccerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //listaTrabajadoresBindingSource.EndEdit();
            //var trabajador = (Trabajador)listaTrabajadoresBindingSource.Current;

            //var resultado = _trabajoresBL.GuardarTrabajador(trabajador);

            //if (resultado.Exitoso == true)
            //{
            //    listaTrabajadoresBindingSource.ResetBindings(false);

            //    DialogResult resul = MessageBox.Show("Usuario Guardado", "Exitoso...!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}

            dataGridView1.DataSource = sql.MostrarDatos();
        }
    }
}
