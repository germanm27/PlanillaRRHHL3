using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH.BL
{
    public class EgresosBL
    {
        Contexto _contexto;
        public BindingList<Egreso> ListaEgresos { get; set; }

        public EgresosBL()
        {
            _contexto = new Contexto();
            ListaEgresos = new BindingList<Egreso>();
        }

        public BindingList<Egreso> ObtenerEgresos()
        {
            _contexto.Egresos.Load();

            ListaEgresos = _contexto.Egresos.Local.ToBindingList();
            return ListaEgresos;
        }
    }

    public class Egreso
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
