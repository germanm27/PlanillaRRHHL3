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
    public partial class Planillas : Form
    {
        CargosBL _cargosBL;
        TrabajadoresBL _trabajoresBL;
        JornadaBL _jornadaBL;
        MetodoPagoBL _metodosdePagoBL;
        PlanillaBL _planillaBL;

        public Planillas()
        {
            InitializeComponent();

            _cargosBL = new CargosBL();
            listaCargosBindingSource.DataSource = _cargosBL.ObtenerCargos();

            _trabajoresBL = new TrabajadoresBL();
            listaTrabajadoresBindingSource.DataSource = _trabajoresBL.ObtenerTrabajador();

            _jornadaBL = new JornadaBL();
            listaJornadasBindingSource.DataSource = _jornadaBL.ObtenerJornadas();

            _metodosdePagoBL = new MetodoPagoBL();
            listaMetodoPagosBindingSource.DataSource = _metodosdePagoBL.ObtenerMetodoPagos();

            _planillaBL = new PlanillaBL();
            listaPlanillasBindingSource.DataSource = _planillaBL.ObtenerPlanillas();
        }

        private void Planillas_Load(object sender, EventArgs e)
        {
            DesabilitarEdicion();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _planillaBL.AgregarPlanilla();
            listaPlanillasBindingSource.MoveLast();
            HabilitarEdicion();
            DeshabilitarHabilitarBotones(false);
        }
        #region BotonesEdicion
        public void HabilitarEdicion()
        {
            fechaDateTimePicker.Enabled = true;
            cargoIdComboBox.Enabled = true;
            metodoPagoIdComboBox.Enabled = true;
            jornadaIdComboBox.Enabled = true;
            button1.Enabled = true;
            button2.Enabled = true;
            planillaDetalleDataGridView.Enabled = true;
        }

        public void DesabilitarEdicion()
        {
            fechaDateTimePicker.Enabled = false;
            cargoIdComboBox.Enabled = false;
            metodoPagoIdComboBox.Enabled = false;
            jornadaIdComboBox.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            planillaDetalleDataGridView.Enabled = false;
        }
        #endregion

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;
            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
            toolStripButton1.Enabled = valor;

        }

        private void listaPlanillasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaPlanillasBindingSource.EndEdit();

            var planilla = (Planilla)listaPlanillasBindingSource.Current;
            var resultado = _planillaBL.GuardarPlanilla(planilla);

            if (resultado.Exitoso == true)
            {
                listaPlanillasBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);

                DialogResult result = MessageBox.Show("Planilla Guardada", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            DesabilitarEdicion();
            _planillaBL.CancelarCambios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var planilla = (Planilla)listaPlanillasBindingSource.Current;
            _planillaBL.AgregarPlanillaDetalle(planilla);

            DeshabilitarHabilitarBotones(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var planilla = (Planilla)listaPlanillasBindingSource.Current;
            var planillaDetalle = (PlanillaDetalle)planillaDetalleBindingSource.Current;

            _planillaBL.RemoverPlanillaDetalle(planilla, planillaDetalle);


            _planillaBL.RemoverDetalle(planilla);

            listaPlanillasBindingSource.ResetBindings(false);
        }

        private void planillaDetalleDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void planillaDetalleDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var planilla = (Planilla)listaPlanillasBindingSource.Current;
            _planillaBL.CalcularPlanilla(planilla);

            listaPlanillasBindingSource.ResetBindings(false);
        }

        private void planillaDetalleDataGridView_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false;
        }

        private void planillaDetalleDataGridView_CellEndEdit_1(object sender, DataGridViewCellEventArgs e)
        {
            var planilla = (Planilla)listaPlanillasBindingSource.Current;
            _planillaBL.CalcularPlanilla(planilla);

            //LinQ
            //var planillaDetalle = (PlanillaDetalle)planillaDetalleBindingSource.Current;
            //if (planillaDetalle != null)
            //{
            //    var trabajador = _trabajoresBL.ObtenerTrabajador(planillaDetalle.TrabajadorId);
            //    listaCargosBindingSource.DataSource = _cargosBL.ObtenerCargos(trabajador.CargoId);
            //}

            listaPlanillasBindingSource.ResetBindings(false);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox1.Text != "")
            {
                var resultado = MessageBox.Show("Desea Anular esta Planilla", "Anular", MessageBoxButtons.YesNo);
                if ( resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox1.Text);
                    Anular(id);
                }
            }
        }

        private void Anular(int id)
        {
            var resultado = _planillaBL.AnularFactura(id);

            if (resultado == true)
            {
                listaPlanillasBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio en error al anular la planilla");
            }
        }

        private void listaPlanillasBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var planilla = (Planilla)listaPlanillasBindingSource.Current;

            if (planilla != null && planilla.Id != 0 && planilla.Activo == false)
            {
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            listaPlanillasBindingNavigatorSaveItem.Enabled = true;
            toolStripButtonCancelar.Visible = true;
            toolStripButtonCancelar.Enabled = true;
            HabilitarEdicion();
        }
    }
}
