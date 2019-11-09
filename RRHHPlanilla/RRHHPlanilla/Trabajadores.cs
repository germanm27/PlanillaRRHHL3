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
    public partial class Trabajadores : Form
    {
        TrabajadoresBL _trabajadores;

        public Trabajadores()
        {
            InitializeComponent();
            _trabajadores = new TrabajadoresBL();
            listaTrabajadoresBindingSource.DataSource = 
                _trabajadores.ObtenerTrabajador();
        }

        private void listaTrabajadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaTrabajadoresBindingSource.EndEdit();
            var trabajador = (Trabajador)listaTrabajadoresBindingSource.Current;
            var resultado = _trabajadores.GuardarTrabajador(trabajador);

            if (resultado.Exitoso == true)
            {
                listaTrabajadoresBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _trabajadores.AgregarTrabajador();
            listaTrabajadoresBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;
            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripCancelar.Visible = !valor;

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                DialogResult resulto = MessageBox.Show("¿Desea Eliminar el Registro?", "Eliminar", 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resulto == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

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

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            Eliminar(0);
        }
    }
}
