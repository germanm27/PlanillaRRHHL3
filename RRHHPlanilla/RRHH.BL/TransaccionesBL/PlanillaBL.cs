using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH.BL
{
    public class PlanillaBL
    {
        Contexto _contexto;

        public BindingList<Planilla> ListaPlanillas { get; set; }


        public PlanillaBL()
        {
            _contexto = new Contexto();

            //ListaPlanillas = new BindingList<Planilla>();
        }

        public BindingList<Planilla> ObtenerPlanillas()
        {
            _contexto.Planillas.Include("PlanillaDetalle").Load();

            ListaPlanillas = _contexto.Planillas.Local.ToBindingList();
            return ListaPlanillas;
        }

        //AGREGAR Y REMOVER
        public void AgregarPlanilla()
        {
            var nuevaplanilla = new Planilla();
            ListaPlanillas.Add(nuevaplanilla);
        }

        public void AgregarPlanillaDetalle(Planilla planilla)
        {
            if (planilla != null)
            {
                var nuevoDetalle = new PlanillaDetalle();
                planilla.PlanillaDetalle.Add(nuevoDetalle);
            }
        }

        public void RemoverPlanillaDetalle(Planilla planilla, PlanillaDetalle planillaDetalle)
        {
            if (planilla != null && planillaDetalle != null)
            {
                planilla.PlanillaDetalle.Remove(planillaDetalle);

                
            }
        }

        //CANCELAR CAMBIOS
        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        // GUARDAD
        public Resultado3 GuardarPlanilla(Planilla planilla)
        {
            var resultado = Validar(planilla);

            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();

            resultado.Exitoso = true;
            return resultado;
        }

        //REMOVER
        public void RemoverDetalle(Planilla planilla)
        {
            int cant = 1;
            planilla.CantEmpleados -= cant;

        }

        //CALCULOS
        public void CalcularPlanilla(Planilla planilla)
        {
            if (planilla != null)
            {
                int cant = 0;


                double RAP = 0.015;
                double IHSS = 0.025;

                double primsueldo = 13249.5;
                double ISR1 = 0.15;

                double segsueldo = 20203.3;     
                double ISR2 = 0.20;

                double tercsueldo = 46984.4; 
                double ISR3 = 0.25;

                double Banco = 1000;
                double Cooperativa = 500;

                double TotalDeducciones = 0;
                double Sueldo = 0;
                double TotNeto = 0;

                foreach (var detalle in planilla.PlanillaDetalle)
                {
                    var trabajador = _contexto.Trabajadores.Find(detalle.TrabajadorId);

                    if (trabajador != null)
                    {

                        detalle.Sueldo = trabajador.Sueldo;
                        detalle.Cargo = trabajador.CargoId;
                        detalle.Jornada = trabajador.JornadaId;
                        detalle.MetodoPago = trabajador.MetodoPagoId;

                        detalle.Cantidad = 1;
                        

                        detalle.RAP = trabajador.Sueldo * RAP;
                        detalle.IHSS = trabajador.Sueldo * IHSS;
                        detalle.Banco = Banco;
                        detalle.Cooperativa = Cooperativa;

                        if (trabajador.Sueldo <= 13249.5)
                        {
                            detalle.ISR = 0;
                        }

                        if (trabajador.Sueldo > primsueldo && trabajador.Sueldo <= segsueldo)
                        {
                            detalle.ISR = trabajador.Sueldo * ISR1;
                        }

                        if (trabajador.Sueldo > segsueldo && trabajador.Sueldo <= tercsueldo)
                        {
                            detalle.ISR = trabajador.Sueldo * ISR2;
                        }

                        if (trabajador.Sueldo > tercsueldo)
                        {
                            detalle.ISR = trabajador.Sueldo * ISR3;
                        }

                        detalle.Banco = Banco;
                        detalle.Cooperativa = Cooperativa;

                        detalle.Deducciones = detalle.IHSS + detalle.ISR + detalle.RAP + detalle.Banco + detalle.Cooperativa + detalle.Banco + detalle.Cooperativa;
                        detalle.PagoTotal = trabajador.Sueldo - detalle.Deducciones;

                        cant = detalle.Cantidad;
                        TotalDeducciones = detalle.Deducciones;
                        Sueldo = detalle.Sueldo;
                        TotNeto = detalle.PagoTotal;
                            
                    }
                }

                planilla.CantEmpleados += cant;
                planilla.TOTDeducciones += TotalDeducciones;
                planilla.TOTSueldoBase += Sueldo;
                planilla.TOTSalarioNeto += TotNeto;
            }
        }

        //ANULAR
        public bool  AnularFactura(int id)
        {
            foreach (var planilla in ListaPlanillas)
            {
                if (planilla.Id == id)
                {
                    planilla.Activo = false;
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;

        }

        //VALIDACION
        private Resultado3 Validar(Planilla planilla)
        {
            var resultado = new Resultado3 ();
            resultado.Exitoso = true;

            if (planilla == null)
            {
                resultado.Mensaje = "Agregue una Factura para Guardar";
                resultado.Exitoso = false;

                return resultado;
            }

            if (planilla.Activo == false)
            {
                resultado.Mensaje = "La Factura esta Anulada y no se puede modificar";
                resultado.Exitoso = false;                
            }

            if (planilla.CargoId == 0)
            {
                resultado.Mensaje = "Seleccion un Cargo";
                resultado.Exitoso = false;
            }

            if (planilla.JornadaId == 0)
            {
                resultado.Mensaje = "Seleccion una Jornada";
                resultado.Exitoso = false;
            }

            if (planilla.MetodoPagoId == 0)
            {
                resultado.Mensaje = "Seleccion un Metodo de Pago";
                resultado.Exitoso = false;
            }

            if (planilla.PlanillaDetalle.Count == 0)
            {
                resultado.Mensaje = "Agregue un Trabajador a la Planilla";
                resultado.Exitoso = false;
            }

            foreach (var detalle in planilla.PlanillaDetalle)
            {
                if (detalle.TrabajadorId == 0)
                {
                    resultado.Mensaje = "Seleccion un Trabajador";
                    resultado.Exitoso = false;
                }
            }
            return resultado;
        }

    }

    public class Planilla
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }

        //BUSQUEDA
        public int JornadaId { get; set; }
        public Jornada Jornada { get; set; }
        public int MetodoPagoId { get; set; }
        public MetodoPago MetodoPago { get; set; }
        public int CargoId { get; set; }
        public Cargo Cargo { get; set; }
        public BindingList<PlanillaDetalle> PlanillaDetalle { get; set; }

        //TOTALES DE FORMULAS 
        public double CantEmpleados { get; set; }
        public double TOTSueldoBase { get; set; }
        public double TOTDeducciones { get; set; }
        public double TOTSalarioNeto { get; set; }

        public bool Activo { get; set; }


        public Planilla()
        {
            Fecha = DateTime.Now;
            PlanillaDetalle = new BindingList<PlanillaDetalle>(); 
            Activo = true;
        }
    }

    public class PlanillaDetalle
    {
        public int Id { get; set; }
        public int TrabajadorId { get; set; }
        public Trabajador Trabajador { get; set; }
        public double Sueldo { get; set; }
        public int Cargo { get; set; }
        public int Jornada { get; set; }
        public int MetodoPago { get; set; }

        //public int JornadaId { get; set; }
        //public Jornada Jornada { get; set; }

        //public int CargoId { get; set; }
        //public Cargo Cargo { get; set; }


        // public int HorasExtra { get; set; }
        public double RAP { get; set; }
        public double IHSS { get; set; }
        public double ISR { get; set; }
        public double Banco { get; set; }
        public double Cooperativa { get; set; }


        public int Cantidad { get; set; }
        public double Deducciones { get; set; }        
        public double PagoTotal { get; set; }

        //BUSQUEDA
        
        

        public PlanillaDetalle()
        {
            Cantidad = 1;             
        }



    }

}
