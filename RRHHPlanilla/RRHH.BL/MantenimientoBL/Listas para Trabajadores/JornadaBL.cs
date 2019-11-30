using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH.BL
{
    public class JornadaBL
    {
        Contexto _contexto;
        public BindingList<Jornada> ListaJornadas { get; set; }

        public JornadaBL()
        {
            _contexto = new Contexto();
            ListaJornadas = new BindingList<Jornada>();
        }

        public BindingList<Jornada> ObtenerJornadas()
        {
            _contexto.Jornadas.Load();

            ListaJornadas = _contexto.Jornadas.Local.ToBindingList();
            return ListaJornadas;
        }
    }

    public class Jornada
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}