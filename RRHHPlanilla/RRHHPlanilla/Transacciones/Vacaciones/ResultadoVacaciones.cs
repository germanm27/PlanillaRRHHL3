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

namespace RRHHPlanilla.Transacciones.Vacaciones
{
    public partial class ResultadoVacaciones : Form
    {
        TrabajadoresBL _trabajadores;
        CargosBL _cargosBL;
        JornadaBL _jornadaBL;
        EstadoCivilBL _estadocivilBL;
        MetodoPagoBL _metodopagoBL;
        SexoBL _sexoBL;
        ExTrabajadoresBL _extrabajadorBL;
        VacacionesBL _VacacionBL;


        public ResultadoVacaciones()
        {
            InitializeComponent();
            _sexoBL = new SexoBL();
            listaSexosBindingSource.DataSource = _sexoBL.ObtenerSexos();

            _trabajadores = new TrabajadoresBL();
            listaTrabajadoresBindingSource.DataSource = _trabajadores.ObtenerTrabajador();

            _cargosBL = new CargosBL();
            listaCargosBindingSource.DataSource = _cargosBL.ObtenerCargos();

            _jornadaBL = new JornadaBL();
            listaJornadasBindingSource.DataSource = _jornadaBL.ObtenerJornadas();

            _estadocivilBL = new EstadoCivilBL();
            listaEstadoCivilesBindingSource.DataSource = _estadocivilBL.ObtenerEstadoCiviles();

            _metodopagoBL = new MetodoPagoBL();
            listaMetodoPagosBindingSource.DataSource = _metodopagoBL.ObtenerMetodoPagos();

            _extrabajadorBL = new ExTrabajadoresBL();
            listaExTrabajadoresBindingSource.DataSource = _extrabajadorBL.ObtenerExTrabajador();

            _VacacionBL = new VacacionesBL();
            listaVacacionesBindingSource.DataSource = _VacacionBL.ObtenerVacaciones();

        }

        private void piccerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResultadoVacaciones_Load(object sender, EventArgs e)
        {

        }
    }
}
