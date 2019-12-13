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

        public Asistencia()
        {
            InitializeComponent();

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
                    _trabajadores.ObtenerTrabajador2(buscar,buscar2);

                listaTrabajadoresBindingSource.ResetBindings(false);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
