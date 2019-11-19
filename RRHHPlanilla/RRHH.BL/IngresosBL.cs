using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH.BL
{
    public class IngresosBL
    {
        Contexto _contexto;
        public BindingList<Ingreso> ListaIngresos { get; set; }

        public IngresosBL()
        {
            _contexto = new Contexto();
            ListaIngresos = new BindingList<Ingreso>();
        }

        public BindingList<Ingreso> ObtenerIngresos()
        {
            _contexto.Ingresos.Load();

            ListaIngresos = _contexto.Ingresos.Local.ToBindingList();
            return ListaIngresos;
        }
    }

    public class Ingreso
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
