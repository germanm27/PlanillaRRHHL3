﻿using RRHH.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RRHHPlanilla.Transacciones.Anticipo
{
    public partial class ResultadoAnticipo : Form
    {
        TrabajadoresBL _trabajadores;
        CargosBL _cargosBL;
        JornadaBL _jornadaBL;
        EstadoCivilBL _estadocivilBL;
        MetodoPagoBL _metodopagoBL;
        SexoBL _sexoBL;
        ExTrabajadoresBL _extrabajadorBL;
        AnticiposBL _anticipoBL;

        public ResultadoAnticipo()
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

            _anticipoBL = new AnticiposBL();
            listaAnticiposBindingSource.DataSource = _anticipoBL.ObtenerAnticipos();

        }

        private void piccerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResultadoAnticipo_Load(object sender, EventArgs e)
        {

        }
    }
}
