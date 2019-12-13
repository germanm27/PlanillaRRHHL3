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
    public partial class ReportedeVacaciones : Form
    {
        public ReportedeVacaciones()
        {
            InitializeComponent();

            var _vacacionesBL = new VacacionesBL();
            //var _trabajadoresBL = new TrabajadoresBL();
            var _cargosBL = new CargosBL();
            var _jornadaBL = new JornadaBL();
            var _metodoPago = new MetodoPagoBL();

            var bindingSource = new BindingSource();
            bindingSource.DataSource = _vacacionesBL.ObtenerVacaciones();

            //var bindingSource2 = new BindingSource();
            //bindingSource2.DataSource = _trabajadoresBL.ObtenerTrabajador();

            var bindingSource3 = new BindingSource();
            bindingSource3.DataSource = _cargosBL.ObtenerCargos();

            var bindingSource4 = new BindingSource();
            bindingSource4.DataSource = _jornadaBL.ObtenerJornadas();

            var bindingSource5 = new BindingSource();
            bindingSource5.DataSource = _metodoPago.ObtenerMetodoPagos();

            var reporte = new ReporteVacaciones();
            reporte.Database.Tables["Vacacion"].SetDataSource(bindingSource);
            //reporte.Database.Tables["Trabajador"].SetDataSource(bindingSource2);
            reporte.Database.Tables["Cargo"].SetDataSource(bindingSource3);
            reporte.Database.Tables["Jornada"].SetDataSource(bindingSource4);
            reporte.Database.Tables["MetodoPago"].SetDataSource(bindingSource5);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
