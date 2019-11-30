using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RRHH.BL.Trabajador;

namespace RRHH.BL
{
    public class TrabajadoresBL
    {
        Contexto _contexto;
        public BindingList<Trabajador> ListaTrabajadores { get; set; }

        public TrabajadoresBL()
        {
            _contexto = new Contexto();
            ListaTrabajadores = new BindingList<Trabajador>();
        }

        public BindingList<Trabajador> ObtenerTrabajador()
        {
            _contexto.Trabajadores.Load();

            ListaTrabajadores = _contexto.Trabajadores.Local.ToBindingList();
            return ListaTrabajadores;
        }

        public Trabajador ObtenerTrabajador(int trabajadorId)
        {
            return _contexto.Trabajadores.FirstOrDefault(r => r.Id == trabajadorId);
        }

        public Resultado GuardarTrabajador(Trabajador trabajador)
        {           
            var resultado = Validar(trabajador);
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

        public void AgregarTrabajador()
        {
            var nuevoTrabajador = new Trabajador();
            ListaTrabajadores.Add(nuevoTrabajador);
        }

        public bool EliminarTrabajador(int id)
        {
            foreach (var trabajador in ListaTrabajadores)
            {
                if (trabajador.Id == id)
                {
                    ListaTrabajadores.Remove(trabajador);
                    _contexto.SaveChanges();

                    return true;
                }
            }
            return false;

        }

        private Resultado Validar(Trabajador trabajador)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;
            
            if (trabajador == null)
            {
                resultado.Mensaje = "Agregar un trabajador";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(trabajador.Nombre) == true)

            {
                resultado.Mensaje = "Ingrese el Nombre";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(trabajador.Apellido) == true)
            {
                resultado.Mensaje = "Ingrese el Apellido";
                resultado.Exitoso = false;
            }

            if (trabajador.SexoId <= 0)
            {
                resultado.Mensaje = "Ingrese el Sexo";
                resultado.Exitoso = false;
            }

            if (trabajador.Edad <= 0)
            {
                resultado.Mensaje = "La edad debe se mayor a 0";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(trabajador.Direccion) == true)
            {
                resultado.Exitoso = false;
                resultado.Mensaje = "Ingrese la dirección";
            }

            if (trabajador.Sueldo <= 0)
            {
                resultado.Exitoso = false;
                resultado.Mensaje = "Ingrese el sueldo";
            }

            if (trabajador.CargoId <= 0)
            {
                resultado.Exitoso = false;
                resultado.Mensaje = "Ingrese el sueldo";
            }

            if (trabajador.MetodoPagoId <= 0)
            {
                resultado.Exitoso = false;
                resultado.Mensaje = "Ingrese el sueldo";
            }

            if (trabajador.JornadaId <= 0)
            {
                resultado.Exitoso = false;
                resultado.Mensaje = "Ingrese el sueldo";
            }

            if (trabajador.EstadoCivilId <= 0)
            {
                resultado.Exitoso = false;
                resultado.Mensaje = "Ingrese el sueldo";
            }

            return resultado;
        }
    }

    public class Trabajador
    {
        public byte[] Foto { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int SexoId { get; set; }
        public Sexo Sexo { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public double Sueldo { get; set; }
        public int CargoId { get; set; }
        public Cargo Cargos { get; set; }
        public int MetodoPagoId { get; set; }
        public MetodoPago MetodoPago { get; set; }
        public int JornadaId { get; set; }
        public Jornada Jornada { get; set; }
        public int EstadoCivilId { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public DateTime FechaInicio { get; set; }
        public double Cedula { get; set; }

        public Trabajador()
        {
            FechaInicio = DateTime.Now;
        }

        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }
        }
    }
}