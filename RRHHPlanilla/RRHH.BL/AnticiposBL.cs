using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RRHH.BL.Anticipo;

namespace RRHH.BL
{
    public class AnticiposBL
    {
        Contexto _contexto;
        public BindingList<Anticipo> ListaAnticipos { get; set; }

        public AnticiposBL()
        {
            _contexto = new Contexto();
            ListaAnticipos = new BindingList<Anticipo>();
        }

        public BindingList<Anticipo> ObtenerAnticipos()
        {
            _contexto.Anticipos.Load();

            ListaAnticipos = _contexto.Anticipos.Local.ToBindingList();
            return ListaAnticipos;
        }

        public Anticipo ObtenerAnticipos(int anticipoId)
        {
            return _contexto.Anticipos.FirstOrDefault(r => r.Id == anticipoId);
        }

        public Resultado GuardaAnticipos(Anticipo anticipo)
        {
            var resultado = Validar(anticipo);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public void AgregarAnticipo()
        {
            var nuevoAnticipo = new Anticipo();
            ListaAnticipos.Add(nuevoAnticipo);
        }


        public bool EliminarAnticipo(int id)
        {
            foreach (var anticipo in ListaAnticipos)
            {
                if (anticipo.Id == id)
                {
                    ListaAnticipos.Remove(anticipo);
                    _contexto.SaveChanges();

                    return true;
                }
            }
            return false;

        }
        private Resultado Validar(Anticipo anticipo)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (anticipo == null)
            {
                resultado.Mensaje = "Agregar un Anticipo";
                resultado.Exitoso = false;
            }

            if (anticipo.SueldoBruto == 0)

            {
                resultado.Mensaje = "Ingrese Anticipo disponibles";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }


    public class Anticipo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int SueldoBruto { get; set; }
        public int Anti { get; set; }
        public DateTime FechaAnticipo { get; set; }
        public int SueldoNeto { get; set; }
        public int TrabajadorId { get; set; }
        public Trabajador Trabajador { get; set; }

        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }
        }

    }
}
    