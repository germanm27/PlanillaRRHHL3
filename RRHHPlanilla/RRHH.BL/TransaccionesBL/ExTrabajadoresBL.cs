using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RRHH.BL.ExTrabajador;

namespace RRHH.BL
{
    public class ExTrabajadoresBL
    {
        Contexto _contexto;
        public BindingList<ExTrabajador> ListaExTrabajadores { get; set; }

        public ExTrabajadoresBL()
        {
            _contexto = new Contexto();
            ListaExTrabajadores = new BindingList<ExTrabajador>();
        }

        public BindingList<ExTrabajador> ObtenerExTrabajador()
        {
            _contexto.ExTrabajadores.Load();

            ListaExTrabajadores = _contexto.ExTrabajadores.Local.ToBindingList();
            return ListaExTrabajadores;
        }
        public ExTrabajador ObtenerTrabajador(int extrabajadorId)
        {
            return _contexto.ExTrabajadores.FirstOrDefault(r => r.Id == extrabajadorId);
        }

        public Resultado GuardarExTrabajador(ExTrabajador extrabajador)
        {
            var resultado = Validar(extrabajador);
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

        public void AgregarExTrabajador()
        {
            var nuevoExtrabajador = new ExTrabajador();
            ListaExTrabajadores.Add(nuevoExtrabajador);
        }


        public bool EliminarExTrabajador(int id)
        {
            foreach (var extrabajador in ListaExTrabajadores)
            {
                if (extrabajador.Id == id)
                {
                    ListaExTrabajadores.Remove(extrabajador);
                    _contexto.SaveChanges();

                    return true;
                }
            }
            return false;

        }


        private Resultado Validar(ExTrabajador extrabajador)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (extrabajador == null)
            {
                resultado.Mensaje = "Agregar un trabajador";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(extrabajador.Nombre) == true)

            {
                resultado.Mensaje = "Ingrese el Nombre";
                resultado.Exitoso = false;
            }



            return resultado;
        }
    }



    public class ExTrabajador
    {
        public byte[] Foto { get; set; }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        //public int SexoId { get; set; }
        //public Sexo Sexo { get; set; }
        //public int Edad { get; set; }
        //public string Direccion { get; set; }
        public double Sueldo { get; set; }
        public int CargoId { get; set; }
        public Cargo Cargos { get; set; }
        public int MetodoPagoId { get; set; }
        public MetodoPago MetodoPago { get; set; }
        public int JornadaId { get; set; }
        public Jornada Jornada { get; set; }
        //public int EstadoCivilId { get; set; }
        //public EstadoCivil EstadoCivil { get; set; }
        public DateTime FechaInicio { get; set; }
        public double Cedula { get; set; }
        public DateTime FechaFinal { get; set; }
        public string Motivo { get; set; }
        public int SueldoMensual { get; set; }
        public int SueldoDiario { get; set; }
        public int Preaviso { get; set; }
        public int Cesantia { get; set; }
        public int CesantiaPro { get; set; }
        public int Vacaciones { get; set; }
        public int TotalPrestaciones { get; set; }


        public class Resultado
        {
            public bool Exitoso { get; set; }
            public string Mensaje { get; set; }
        }
    }
}