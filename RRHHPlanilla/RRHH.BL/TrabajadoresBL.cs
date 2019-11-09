using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH.BL
{
    public class TrabajadoresBL
    {
        public BindingList<Trabajador> ListaTrabajadores { get; set; }


        public TrabajadoresBL()
        {
            ListaTrabajadores = new BindingList<Trabajador>();

            var trabajador1 = new Trabajador();
            trabajador1.Id = 1;
            trabajador1.Nombre = "German";
            trabajador1.Apellido = "Mendoza";
            trabajador1.Sexo = "Masculino";
            trabajador1.Edad = 22;
            trabajador1.Direccion = "Unah Vs";

            ListaTrabajadores.Add(trabajador1);

            var trabajador2 = new Trabajador();
            trabajador2.Id = 2;
            trabajador2.Nombre = "Kevin";
            trabajador2.Apellido = "Amaya";
            trabajador2.Sexo = "Masculino";
            trabajador2.Edad = 23;
            trabajador2.Direccion = "Unah Vs";

            ListaTrabajadores.Add(trabajador2);

            var trabajador3 = new Trabajador();
            trabajador3.Id = 3;
            trabajador3.Nombre = "Juan";
            trabajador3.Apellido = "Alvarado";
            trabajador3.Sexo = "Masculino";
            trabajador3.Edad = 23;
            trabajador3.Direccion = "Unah Vs";

            ListaTrabajadores.Add(trabajador3);

            var trabajador4 = new Trabajador();
            trabajador4.Id = 4;
            trabajador4.Nombre = "Luis";
            trabajador4.Apellido = "Lopez";
            trabajador4.Sexo = "Masculino";
            trabajador4.Edad = 45;
            trabajador4.Direccion = "Unah Vs";

            ListaTrabajadores.Add(trabajador4);
        }
        public BindingList<Trabajador> ObtenerTrabajador()
        {
            return ListaTrabajadores;
        }

        public Resultado GuardarTrabajador(Trabajador trabajador)
        {
            var resultado = Validar(trabajador);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            if (trabajador.Id == 0)
            {
                trabajador.Id = ListaTrabajadores.Max(item => item.Id) + 1;
            }
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
    }


    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
