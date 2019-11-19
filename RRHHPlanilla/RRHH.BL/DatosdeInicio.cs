using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH.BL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var usuarioAdmin = new Usuario();
            usuarioAdmin.Nombre = "admin";
            usuarioAdmin.Contrasena = "123";
            contexto.Usuarios.Add(usuarioAdmin);

            var usuarioGerente = new Usuario();
            usuarioGerente.Nombre = "Gerente";
            usuarioGerente.Contrasena = "123";
            contexto.Usuarios.Add(usuarioGerente);

            var usuarioSuperv = new Usuario();
            usuarioSuperv.Nombre = "super";
            usuarioSuperv.Contrasena = "123";
            contexto.Usuarios.Add(usuarioSuperv);

            var cargo1 = new Cargo();
            cargo1.Descripcion = "Gerente";
            contexto.Cargos.Add(cargo1);

            var cargo2 = new Cargo();
            cargo2.Descripcion = "Supervisor";
            contexto.Cargos.Add(cargo2);

            var cargo3 = new Cargo();
            cargo3.Descripcion = "Operario";
            contexto.Cargos.Add(cargo3);

            var cargo4 = new Cargo();
            cargo4.Descripcion = "Mantenimeinto";
            contexto.Cargos.Add(cargo4);

            var metodopago1 = new MetodoPago();
            metodopago1.Descripcion = "Mensual";
            contexto.MetodoPagos.Add(metodopago1);

            var metodopago2 = new MetodoPago();
            metodopago2.Descripcion = "Quincenal";
            contexto.MetodoPagos.Add(metodopago2);

            var metodopago3 = new MetodoPago();
            metodopago3.Descripcion = "Semanal";
            contexto.MetodoPagos.Add(metodopago3);

            var metodopago4 = new MetodoPago();
            metodopago4.Descripcion = "Diario";
            contexto.MetodoPagos.Add(metodopago4);

            var egresos1 = new Egreso();
            egresos1.Descripcion = "IHSS";
            contexto.Egresos.Add(egresos1);

            var egresos2 = new Egreso();
            egresos2.Descripcion = "RAP";
            contexto.Egresos.Add(egresos2);

            var egresos3 = new Egreso();
            egresos3.Descripcion = "ISR";
            contexto.Egresos.Add(egresos3);

            var egresos4 = new Egreso();
            egresos4.Descripcion = "ADELANTO";
            contexto.Egresos.Add(egresos4);

            var egresos5 = new Egreso();
            egresos5.Descripcion = "PRESTAMO";
            contexto.Egresos.Add(egresos5);

            var egresos6 = new Egreso();
            egresos6.Descripcion = "COOPERATIVA";
            contexto.Egresos.Add(egresos6);

            var egresos7 = new Egreso();
            egresos7.Descripcion = "FONDO DE PENSIONES";
            contexto.Egresos.Add(egresos7);

            var Ingresos1 = new Ingreso();
            Ingresos1.Descripcion = "Bonos";
            contexto.Ingresos.Add(Ingresos1);

            var Ingresos2 = new Ingreso();
            Ingresos2.Descripcion = "Horas Extras";
            contexto.Ingresos.Add(Ingresos2);

            var jornada1 = new Jornada();
            jornada1.Descripcion = "Diurno";
            contexto.Jornadas.Add(jornada1);

            var jornada2 = new Jornada();
            jornada2.Descripcion = "Nocturno";
            contexto.Jornadas.Add(jornada2);

            var jornada3 = new Jornada();
            jornada3.Descripcion = "Mixto";
            contexto.Jornadas.Add(jornada3);

            var estado1 = new EstadoCivil();
            estado1.Descripcion = "Soltero";
            contexto.EstadoCiviles.Add(estado1);

            var estado2 = new EstadoCivil();
            estado2.Descripcion = "Casado";
            contexto.EstadoCiviles.Add(estado2);

            var estado3 = new EstadoCivil();
            estado3.Descripcion = "Divorciado";
            contexto.EstadoCiviles.Add(estado3);

            var estado4 = new EstadoCivil();
            estado4.Descripcion = "Viudo";
            contexto.EstadoCiviles.Add(estado4);

            var trabajador1 = new Trabajador();
            trabajador1.Nombre = "Kevin";
            trabajador1.Apellido = "Amaya";
            trabajador1.Edad = 21;
            trabajador1.Sexo = "Masculino";
            trabajador1.Sueldo = 25000;
            trabajador1.Direccion = "Unah vs";
            trabajador1.EstadoCivilId = 2;
            trabajador1.CargoId = 1;
            trabajador1.Cargo = cargo1.Descripcion;
            trabajador1.MetodoPagoId = 1;
            trabajador1.JornadaId = 1;
            contexto.Trabajadores.Add(trabajador1);

            var trabajador2 = new Trabajador();
            trabajador2.Nombre = "German";
            trabajador2.Apellido = "Mendoza";
            trabajador2.Edad = 21;
            trabajador2.Sexo = "Masculino";
            trabajador2.Sueldo = 25000;
            trabajador2.Direccion = "Unah vs";
            trabajador2.EstadoCivilId = 1;
            trabajador2.CargoId = 1;
            trabajador2.MetodoPagoId = 1;
            trabajador2.JornadaId = 1;
            contexto.Trabajadores.Add(trabajador2);

            var trabajador3 = new Trabajador();
            trabajador3.Nombre = "Juan";
            trabajador3.Apellido = "Alvarado";
            trabajador3.Edad = 24;
            trabajador3.Sexo = "Masculino";
            trabajador3.Sueldo = 25000;
            trabajador3.Direccion = "Unah vs";
            trabajador3.EstadoCivilId = 1;
            trabajador3.CargoId = 1;
            trabajador3.MetodoPagoId = 1;
            trabajador3.JornadaId = 1;
            contexto.Trabajadores.Add(trabajador3);

            var trabajador4 = new Trabajador();
            trabajador4.Nombre = "Luis";
            trabajador4.Apellido = "Lopez";
            trabajador4.Edad = 45;
            trabajador4.Sexo = "Masculino";
            trabajador4.Sueldo = 25000;
            trabajador4.Direccion = "Unah vs";
            trabajador4.EstadoCivilId = 1;
            trabajador4.CargoId = 1;
            trabajador4.MetodoPagoId = 1;
            trabajador4.JornadaId = 1;
            contexto.Trabajadores.Add(trabajador4);

            var trabajador5 = new Trabajador();
            trabajador5.Nombre = "Ariana";
            trabajador5.Apellido = "Mendoza";
            trabajador5.Edad = 26;
            trabajador5.Sexo = "Femenino";
            trabajador5.Sueldo = 15000;
            trabajador5.Direccion = "Unah vs";
            trabajador5.EstadoCivilId = 1;
            trabajador5.CargoId = 2;
            trabajador5.MetodoPagoId = 1;
            trabajador5.JornadaId = 1;
            contexto.Trabajadores.Add(trabajador5);

            var trabajador6 = new Trabajador();
            trabajador6.Nombre = "Maria";
            trabajador6.Apellido = "Alvarez";
            trabajador6.Edad = 27;
            trabajador6.Sexo = "Femenino";
            trabajador6.Sueldo = 12000;
            trabajador6.Direccion = "Unah vs";
            trabajador6.EstadoCivilId = 1;
            trabajador6.CargoId = 3;
            trabajador6.MetodoPagoId = 1;
            trabajador6.JornadaId = 2;
            contexto.Trabajadores.Add(trabajador6);


            var trabajador7 = new Trabajador();
            trabajador7.Nombre = "Doris";
            trabajador7.Apellido = "Perez";
            trabajador7.Edad = 26;
            trabajador7.Sexo = "Femenino";
            trabajador7.Sueldo = 9800;
            trabajador7.Direccion = "Unah vs";
            trabajador7.EstadoCivilId = 1;
            trabajador7.CargoId = 4;
            trabajador7.MetodoPagoId = 1;
            trabajador7.JornadaId = 2;
            contexto.Trabajadores.Add(trabajador7);

            var capacitacion1 = new Capacitacion();
            capacitacion1.Tema = "Manejo de Conflictos";
            capacitacion1.Horas= "12";
            capacitacion1.Poblacion = "San Pedro Sula";
            capacitacion1.Personal = "German Mendoza y Kevin Amaya";
            capacitacion1.Fecha = "10-Noviembre";
            capacitacion1.Horario = "1:30 Pm a 5:00Pm";
            capacitacion1.Modalidad = "Presencial";
            capacitacion1.Proveedor = "CCIC";
            capacitacion1.Lugar = "CCIC";
            capacitacion1.Presupuesto = "Membresia";
            capacitacion1.Status = "Impartido";
            contexto.Capacitaciones.Add(capacitacion1);

            var capacitacion2 = new Capacitacion();
            capacitacion2.Tema = "Manejo del Personal";
            capacitacion2.Horas = "8";
            capacitacion2.Poblacion = "San Pedro Sula";
            capacitacion2.Personal = "Ariana Mendoza";
            capacitacion2.Fecha = "20-Noviembre";
            capacitacion2.Horario = "1:30 Pm a 5:00Pm";
            capacitacion2.Modalidad = "Presencial";
            capacitacion2.Proveedor = "CCIC";
            capacitacion2.Lugar = "CCIC";
            capacitacion2.Presupuesto = "Membresia";
            capacitacion2.Status = "En Proceso";
            contexto.Capacitaciones.Add(capacitacion2);

            var capacitacion3 = new Capacitacion();
            capacitacion3.Tema = "Manejo del Personal";
            capacitacion3.Horas = "12";
            capacitacion3.Poblacion = "San Pedro Sula";
            capacitacion3.Personal = "Luis Lopez";
            capacitacion3.Fecha = "20-Noviembre";
            capacitacion3.Horario = "1:30 Pm a 5:00Pm";
            capacitacion3.Modalidad = "Presencial";
            capacitacion3.Proveedor = "FUNDAHRSE";
            capacitacion3.Lugar = "Hotel Honduras";
            capacitacion3.Presupuesto = "Membresia";
            capacitacion3.Status = "En Proceso";
            contexto.Capacitaciones.Add(capacitacion3);

            base.Seed(contexto);
        }
    }
}
