using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH.BL
{
    public class CargosBL
    {
        Contexto _contexto;
        public BindingList<Cargo> ListaCargos { get; set; }

        public CargosBL()
        {
            _contexto = new Contexto();
            ListaCargos = new BindingList<Cargo>();
        }

        public BindingList<Cargo> ObtenerCargos()
        {
            _contexto.Cargos.Load();

            ListaCargos = _contexto.Cargos.Local.ToBindingList();
            return ListaCargos;
        }

        public BindingList<Cargo> ObtenerCargos(int cargoId)
        {
            var query = _contexto.Cargos.Where(r => r.Id == cargoId);

            var resultado = new BindingList<Cargo>(query.ToList());

            return resultado;
        }
    }

    public class Cargo
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
