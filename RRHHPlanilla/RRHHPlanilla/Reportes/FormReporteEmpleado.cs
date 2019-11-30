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
    public partial class FormReporteEmpleado : Form
    {
        public FormReporteEmpleado()
        {
            InitializeComponent();

            var _trabajardorBL = new TrabajadoresBL();
            var _cargosBL = new CargosBL();
            var bindingSource = new BindingSource();

            bindingSource.DataSource = _trabajardorBL.ObtenerTrabajador();

            var reporte = new ReporteEmpleados();
            reporte.SetDataSource(bindingSource);
            
            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
