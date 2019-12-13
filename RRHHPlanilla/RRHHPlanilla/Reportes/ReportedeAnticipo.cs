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
    public partial class ReportedeAnticipo : Form
    {
        public ReportedeAnticipo()
        {
            InitializeComponent();

            var _anticipoBL = new AnticiposBL();
            var _cargosBL = new CargosBL();
            var _metodoPagoBL = new MetodoPagoBL();

            var bindingSource = new BindingSource();
            bindingSource.DataSource = _anticipoBL.ObtenerAnticipos();

            var bindingSource3 = new BindingSource();
            bindingSource3.DataSource = _cargosBL.ObtenerCargos();

            var bindingSource4 = new BindingSource();
            bindingSource4.DataSource = _metodoPagoBL.ObtenerMetodoPagos();

            var reporte = new ReporteAnticipo();
            reporte.Database.Tables["Anticipo"].SetDataSource(bindingSource);
            reporte.Database.Tables["Cargo"].SetDataSource(bindingSource3);
            reporte.Database.Tables["MetodoPago"].SetDataSource(bindingSource4);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
