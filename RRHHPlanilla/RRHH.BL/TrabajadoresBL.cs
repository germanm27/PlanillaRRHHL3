using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            if (string.IsNullOrEmpty(trabajador.Sexo) == true)
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

            return resultado;
        }

    }

    public class Trabajador
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public string Direccion { get; set; }
        public byte[] Foto { get; set; }
    }


    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
