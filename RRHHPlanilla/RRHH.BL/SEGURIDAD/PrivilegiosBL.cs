using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH.BL
{
    public class PrivilegiosBL
    {
        Contexto _contexto;
        public BindingList<Privilegio> ListaPrivilegios { get; set; }

        public PrivilegiosBL()
        {
            _contexto = new Contexto();
            ListaPrivilegios = new BindingList<Privilegio>();
        }

        public BindingList<Privilegio> ObtenerPrivilegios()
        {
            _contexto.Privilegios.Load();

            ListaPrivilegios = _contexto.Privilegios.Local.ToBindingList();
            return ListaPrivilegios;
        }
    }

    public class Privilegio
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
