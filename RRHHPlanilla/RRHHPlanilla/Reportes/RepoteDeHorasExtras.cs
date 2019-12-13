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

namespace RRHHPlanilla.Reportes
{
    public partial class RepoteDeHorasExtras : Form
    {
        public RepoteDeHorasExtras()
        {
            InitializeComponent();

            var _horasExtrasBL = new HorasExtrasBL();
            var _trabajadoresBL = new TrabajadoresBL();
            var _cargoBL = new CargosBL();
            var _metododePagoBL = new MetodoPagoBL();
            var _jornadaBL = new JornadaBL();

            var bindingSource = new BindingSource();
            bindingSource.DataSource = _horasExtrasBL.ObtenerHoraExtras();

            var bindingSource2 = new BindingSource();
            bindingSource2.DataSource = _trabajadoresBL.ObtenerTrabajador();

            var bindingSource3 = new BindingSource();
            bindingSource3.DataSource = _cargoBL.ObtenerCargos();

            var bindingSource4 = new BindingSource();
            bindingSource4.DataSource = _metododePagoBL.ObtenerMetodoPagos();

            var reporte = new ReporteHorasExtra();
            reporte.SetDataSource(bindingSource);
            reporte.Database.Tables["HoraExtra"].SetDataSource(bindingSource);
            reporte.Database.Tables["Trabajador"].SetDataSource(bindingSource2);
            reporte.Database.Tables["Cargo"].SetDataSource(bindingSource3);
            reporte.Database.Tables["MetodoPago"].SetDataSource(bindingSource4);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
