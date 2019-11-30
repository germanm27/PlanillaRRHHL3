using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH.BL
{
    public class EstadoCivilBL
    {
        Contexto _contexto;
        public BindingList<EstadoCivil> ListaEstadoCiviles { get; set; }

        public EstadoCivilBL()
        {
            _contexto = new Contexto();
            ListaEstadoCiviles = new BindingList<EstadoCivil>();
        }

        public BindingList<EstadoCivil> ObtenerEstadoCiviles()
        {

            _contexto.EstadoCiviles.Load();
            ListaEstadoCiviles = _contexto.EstadoCiviles.Local.ToBindingList();
            return ListaEstadoCiviles;
        }
    }

    public class EstadoCivil
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}