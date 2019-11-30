using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH.BL
{
    public class MetodoPagoBL
     {
        Contexto _contexto;
        public BindingList<MetodoPago> ListaMetodoPagos { get; set; }

        public MetodoPagoBL()
        {
            _contexto = new Contexto();
            ListaMetodoPagos = new BindingList<MetodoPago>();
        }

        public BindingList<MetodoPago> ObtenerMetodoPagos()
        {
            _contexto.MetodoPagos.Load();

            ListaMetodoPagos = _contexto.MetodoPagos.Local.ToBindingList();
            return ListaMetodoPagos;
        }
    }

    public class MetodoPago
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}

