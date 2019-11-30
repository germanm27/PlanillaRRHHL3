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
    public partial class Capacitaciones : Form
    {
        CapacitacionesBL _capacitacionesBL;
        public Capacitaciones()
        {
            InitializeComponent();

            _capacitacionesBL = new CapacitacionesBL();
            listaCapacitacionesBindingSource.DataSource = _capacitacionesBL.ObtenerCapacitacion();

        }

        private void Capacitaciones_Load(object sender, EventArgs e)
        {

        }

        private void listaCapacitacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaCapacitacionesBindingSource.EndEdit();
            var capacitacion = (Capacitacion)listaCapacitacionesBindingSource.Current;
            var resultado = _capacitacionesBL.GuardarCapacitacion(capacitacion);

            if (resultado.Exitoso == true)
            {
                listaCapacitacionesBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                DialogResult resul = MessageBox.Show("Usuario Guardado", "Exitoso...!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            listaCapacitacionesBindingNavigatorSaveItem.Enabled = true;
            _capacitacionesBL.AgregarCapacitacion();
            listaCapacitacionesBindingSource.MoveLast();

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
                var resultado = MessageBox.Show("Desea eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
             }
        }

        private void Eliminar(int id)
        { 
            var resultado = _capacitacionesBL.EliminarCapacitacion(id);

            if (resultado == true)
            {
                listaCapacitacionesBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar la capacidad");
            }
        }

        private void toolStripCancelar_Click(object sender, EventArgs e)
        {
            _capacitacionesBL.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
           
        }

        private void listaCapacitacionesBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void piccerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
