using RRHH.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RRHH.BL.Vacacion;

namespace RRHH.BL
{
    public class VacacionesBL
    {
        Contexto _contexto;
        public BindingList<Vacacion> ListaVacaciones { get; set; }

        public VacacionesBL()
        {
            _contexto = new Contexto();
            ListaVacaciones = new BindingList<Vacacion>();
        }

        public BindingList<Vacacion> ObtenerVacaciones()
        {
            _contexto.Vacaciones.Load();

            ListaVacaciones = _contexto.Vacaciones.Local.ToBindingList();
            return ListaVacaciones;
        }

        public Vacacion ObtenerVacaciones(int vacacionId)
        {
            return _contexto.Vacaciones.FirstOrDefault(r => r.Id == vacacionId);
        }

        public Resultado GuardaVacaciones(Vacacion vacacion)
        {
            var resultado = Validar(vacacion);
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

        public void AgregarVacacion()
        {
            var nuevoVacacion = new Vacacion();
            ListaVacaciones.Add(nuevoVacacion);
        }


        public bool EliminarVacacion(int id)
        {
            foreach (var vacacion in ListaVacaciones)
            {
                if (vacacion.Id == id)
                {
                    ListaVacaciones.Remove(vacacion);
                    _contexto.SaveChanges();

                    return true;
                }
            }
            return false;

        }
        private Resultado Validar(Vacacion vacacion)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (vacacion == null)
            {
                resultado.Mensaje = "Agregar una Vacacion";
                resultado.Exitoso = false;
            }
            
            if (vacacion.Disponible == 0)

            {
                resultado.Mensaje = "Ingrese vacaciones disponibles";
                resultado.Exitoso = false;
            }
            
            return resultado;
        }
    }


    public class Vacacion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Disponible { get; set; }
        public int Obtenido { get; set; }
        public DateTime Iniciavacacion { get; set; }
        public DateTime Finalizavacacion { get; set; }
        public int Pago { get; set; }
        public int TrabajadorId { get; set; }
        public Trabajador Trabajador { get; set; }
 


        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }
        }

    }
}