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

        public BindingList<Trabajador> ObtenerTrabajador(string buscar1, string buscar2)
        {
            var query = _contexto.Trabajadores.Where(p => p.Nombre.ToLower().Contains(buscar2.ToLower()) || p.CargoId.ToString().Contains(buscar1.ToLower()) == true).ToList();

            var resultado = new BindingList<Trabajador>(query);

            return resultado;
        }

        public BindingList<Trabajador> ObtenerTrabajador2(string buscar1, string buscar2)
        {
            var query = _contexto.Trabajadores.
                
                Where(p => p.Nombre.ToLower().Contains(buscar1.ToLower()) == true
                && p.Apellido.ToLower().Contains(buscar2.ToLower()) == true).ToList();

            var resultado = new BindingList<Trabajador>(query);

            return resultado;
        }

        public BindingList<Trabajador> ObtenerTrabajadores(string buscar)
        {
            var query = _contexto.Trabajadores.Include("Cargos").Where(r => r.Nombre.ToLower().Contains(buscar.ToLower()) == true
            || r.Cedula.ToString().Contains(buscar) == true || r.Cargos.Descripcion.ToLower().Contains(buscar.ToLower())).ToList();


            var resultado = new BindingList<Trabajador>(query.ToList());
            
            return resultado;
        }

        //BUSQUEDA
        public BindingList<Trabajador> ObtenerTrabajadores2(string cargo, string metodo, string jornada)
        {
            var query = _contexto.Trabajadores
            .Include("Cargos")
            .Include("MetodoPago")
            .Include("Jornada")
            .Where(r => r.Nombre.ToLower().Contains(cargo.ToLower()) == true
            && r.Nombre.ToLower().Contains(metodo.ToLower()) == true
            && r.Nombre.ToLower().Contains(jornada.ToLower()) == true
            || r.Cargos.Descripcion.ToLower().Contains(cargo.ToLower())
            && r.MetodoPago.Descripcion.ToLower().Contains(metodo.ToLower())
            && r.Jornada.Descripcion.ToLower().Contains(jornada.ToLower())
            ).ToList();

            var resultado = new BindingList<Trabajador>(query.ToList());

            return resultado;
        }

        //public Trabajador ObtenerTrabajador(int trabajadorId)
        //{
        //    return _contexto.Trabajadores.FirstOrDefault(r => r.Id == trabajadorId);
        //}

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
                resultado.Mensaje = "Ingrese un Cargo";
            }

            if (trabajador.MetodoPagoId <= 0)
            {
                resultado.Exitoso = false;
                resultado.Mensaje = "Ingrese un Metodo de Pago";
            }

            if (trabajador.JornadaId <= 0)
            {
                resultado.Exitoso = false;
                resultado.Mensaje = "Ingrese una Jornada";
            }

            if (trabajador.EstadoCivilId <= 0)
            {
                resultado.Exitoso = false;
                resultado.Mensaje = "Ingrese un Estado Civil";
            }

            if (trabajador.Cedula < 13)
            {
                resultado.Exitoso = false;
                resultado.Mensaje = "Ingrese un Numero de Cedula Valido";
            }

            if (trabajador.Edad < 18)
            {
                resultado.Exitoso = false;
                resultado.Mensaje = "Ingrese una Edad Valida";
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
        public int DisponibleDia { get; set; }
        public int FechaGenerado { get; set; }
        public int Bono { get; set; }
        public string Personalidad { get; set; }
        public string Detalle { get; set; }
        

        public byte[] CodigoBarras { get; set; }

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