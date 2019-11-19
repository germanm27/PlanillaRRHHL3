using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH.BL
{
    public class CapacitacionesBL
    {
        Contexto _contexto;
        public BindingList<Capacitacion> ListaCapacitaciones { get; set; }

        public CapacitacionesBL()
        {
            _contexto = new Contexto();
            ListaCapacitaciones = new BindingList<Capacitacion>();
        }

        public BindingList<Capacitacion> ObtenerCapacitacion()
        {
            _contexto.Capacitaciones.Load();

            ListaCapacitaciones = _contexto.Capacitaciones.Local.ToBindingList();
            return ListaCapacitaciones;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }


        public Resultado1 GuardarCapacitacion(Capacitacion capacitacion)
        {
            var resultado = Validar(capacitacion);
            
            if(resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarCapacitacion()
        {
            var nuevacapacitacion = new Capacitacion();
            ListaCapacitaciones.Add(nuevacapacitacion);
        }

        public bool EliminarCapacitacion(int id)
        {
            foreach (var capacitacion in ListaCapacitaciones)
            {
                if (capacitacion.Id == id)
                {
                    ListaCapacitaciones.Remove(capacitacion);
                    _contexto.SaveChanges();
                    return true;
                }
             }
            return false;
        }

        private Resultado1 Validar(Capacitacion capacitacion)
        {
            var resultado = new Resultado1();
            resultado.Exitoso = true;

            if (string.IsNullOrEmpty(capacitacion.Tema) == true)
            {
                resultado.Mensaje = "Ingrese el Tema";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(capacitacion.Horas) == true)
            {
                resultado.Mensaje = "Ingrese el Tema";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(capacitacion.Poblacion) == true)
            {
                resultado.Mensaje = "Ingrese el Tema";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(capacitacion.Fecha) == true)
            {
                resultado.Mensaje = "Ingrese el Tema";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(capacitacion.Horario) == true)
            {
                resultado.Mensaje = "Ingrese el Tema";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(capacitacion.Modalidad)== true)
            {
                resultado.Mensaje = "Ingrese el Tema";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(capacitacion.Proveedor) == true)
            {
                resultado.Mensaje = "Ingrese el Tema";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(capacitacion.Lugar) == true)
            {
                resultado.Mensaje = "Ingrese el Tema";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(capacitacion.Presupuesto) == true)
            {
                resultado.Mensaje = "Ingrese el Tema";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(capacitacion.Status) == true)
            {
                resultado.Mensaje = "Ingrese el Tema";
                resultado.Exitoso = false;
            }
            return resultado;
        }
   }



    public class Capacitacion
        {
            public int Id { get; set; }
            public string Tema { get; set; }
            public string Horas { get; set; }
            public string Poblacion { get; set; }
            public string Personal { get; set; }
            public string Fecha { get; set; }
            public string Horario { get; set; }
            public string Modalidad { get; set; }
            public string Proveedor { get; set; }
            public string Lugar { get; set; }
            public string Presupuesto { get; set; }
            public string Status { get; set; }
        }

     public class Resultado1
    {
        public bool Exitoso { get; set;}
        public string Mensaje { get; set; }
    }
}


