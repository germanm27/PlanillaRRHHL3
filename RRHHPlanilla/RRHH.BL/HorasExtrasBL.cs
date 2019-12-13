using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static RRHH.BL.HoraExtra;

namespace RRHH.BL
{
   public  class HorasExtrasBL
    {

        Contexto _contexto;
        public BindingList<HoraExtra> ListaHoraExtras { get; set; }

        public HorasExtrasBL()
        {
            _contexto = new Contexto();
            ListaHoraExtras = new BindingList<HoraExtra>();
        }

        public BindingList<HoraExtra> ObtenerHoraExtras()
        {
            _contexto.HoraExtras.Load();

            ListaHoraExtras = _contexto.HoraExtras.Local.ToBindingList();
            return ListaHoraExtras;
        }

        public HoraExtra ObtenerHoraExtras(int horaextraId)
        {
            return _contexto.HoraExtras.FirstOrDefault(r => r.Id == horaextraId);
        }

        public Resultado GuardaHoraExtras(HoraExtra horaextra)
        {
            var resultado = Validar(horaextra);
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

        public void AgregarHoraExtra()
        {
            var nuevoHoraExtra = new HoraExtra();
            ListaHoraExtras.Add(nuevoHoraExtra);
        }


        public bool EliminarHoraExtra(int id)
        {
            foreach (var horaextra in ListaHoraExtras)
            {
                if (horaextra.Id == id)
                {
                    ListaHoraExtras.Remove(horaextra);
                    _contexto.SaveChanges();

                    return true;
                }
            }
            return false;

        }
        private Resultado Validar(HoraExtra horaextra)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (horaextra == null)
            {
                resultado.Mensaje = "Agregar hora Extra";
                resultado.Exitoso = false;
            }

            if (horaextra.Cantidad == 0)

            {
                resultado.Mensaje = "Ingrese una Hora Extra disponibles";
                resultado.Exitoso = false;
            }

            return resultado;
        }
    }


    public class HoraExtra
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; set; }
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