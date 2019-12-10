using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH.BL
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            #region SEXO

            var sexo1 = new Sexo();
            sexo1.Descripcion = "Masculino";

            var sexo2 = new Sexo();
            sexo2.Descripcion = "Femenino";

            var sexo3 = new Sexo();
            sexo3.Descripcion = "Otro..";

            #endregion

            #region PRIVILEGIO
            var privi = new Privilegio();
            privi.Descripcion = "Administrador";
            contexto.Privilegios.Add(privi);

            var privi1 = new Privilegio();
            privi1.Descripcion = "Gerente";
            contexto.Privilegios.Add(privi1);

            var privi2 = new Privilegio();
            privi2.Descripcion = "Supervisor";
            contexto.Privilegios.Add(privi2);
            #endregion

            #region USUARIO
            var usuario1 = new Usuario();

            //SEGURIDAD
            usuario1.NombUsuario = "admin";
            usuario1.Contrasena = "123";
            contexto.Usuarios.Add(usuario1);

            usuario1.Nombre = "Kevin";
            usuario1.Apellido = "Rivera";
            usuario1.Correo = "prueba1234@gmail.com";
            usuario1.edad = 22;
            usuario1.Foto = null;
            usuario1.FechaInicio = new DateTime(2000, 4, 29);
            usuario1.Cedula = 0512199700879;
            usuario1.PrivilegioId = 1;


            var usuario2 = new Usuario();

            //SEGURIDAD
            usuario2.NombUsuario = "admin2";
            usuario2.Contrasena = "1234";
            contexto.Usuarios.Add(usuario2);

            usuario2.Nombre = "German";
            usuario2.Apellido = "Mendoza";
            usuario2.Correo = "prueba1234@gmail.com";
            usuario2.edad = 21;
            usuario2.Foto = null;
            usuario2.FechaInicio = new DateTime(2000, 10, 18);
            usuario2.Cedula = 0504199800263;
            usuario2.PrivilegioId = 1;


            var usuario3 = new Usuario();

            //SEGURIDAD
            usuario3.NombUsuario = "super";
            usuario3.Contrasena = "123";
            contexto.Usuarios.Add(usuario3);

            usuario3.Nombre = "Juan";
            usuario3.Apellido = "Lo mismo";
            usuario3.Correo = "prueba1234@gmail.com";
            usuario3.edad = 22;
            usuario3.Foto = null;
            usuario3.FechaInicio = new DateTime(2002, 12, 9);
            usuario3.Cedula = 0512199700999;
            usuario3.PrivilegioId = 3;
            #endregion

            #region ArchivosCSV
            //var archivo = "../../../Mantenimientos2.csv";
            //using (var reader = new StreamReader(archivo))
            //{
            //    reader.ReadLine();

            //    while (!reader.EndOfStream)
            //    {
            //        var line = reader.ReadLine();
            //        var values = line.Split(',');
            //        var nuevoTrabajador = new Trabajador()
            //        {
            //            Foto = null,
            //            Nombre = values[0].ToString(),
            //            Apellido = values[1].ToString(),
            //            Edad = int.Parse(values[2].ToString()),
            //            SexoId = int.Parse(values[3].ToString()),
            //            Sueldo = double.Parse(values[4].ToString()),
            //            Direccion = values[5].ToString(),
            //            EstadoCivilId = int.Parse(values[6].ToString()),
            //            CargoId = int.Parse(values[7].ToString()),
            //            MetodoPagoId = int.Parse(values[8].ToString()),
            //            JornadaId = int.Parse(values[9].ToString()),
            //            FechaInicio = DateTime.Parse(values[10].ToString(), CultureInfo.GetCultureInfo("es")),
            //            Cedula = double.Parse(values[11].ToString())
            //        };
            //        contexto.Trabajadores.Add(nuevoTrabajador);
            //    }
            //}
            #endregion

            #region CARGO
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
            cargo4.Descripcion = "Mantenimiento";
            contexto.Cargos.Add(cargo4);
            #endregion

            #region METODO PAGO

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
            #endregion

            #region EGRESOS E INGRESOS

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

            #endregion

            #region JORNADA

            var jornada1 = new Jornada();
            jornada1.Descripcion = "Diurno";
            contexto.Jornadas.Add(jornada1);

            var jornada2 = new Jornada();
            jornada2.Descripcion = "Nocturno";
            contexto.Jornadas.Add(jornada2);

            var jornada3 = new Jornada();
            jornada3.Descripcion = "Mixto";
            contexto.Jornadas.Add(jornada3);
            #endregion

            #region ESTADO CIVIL
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
            #endregion

            #region EMPLEADOS
            var trabajador1 = new Trabajador();
            trabajador1.Nombre = "Kevin";
            trabajador1.Apellido = "Amaya";
            trabajador1.Edad = 21;
            trabajador1.Sexo = sexo1;
            trabajador1.Sueldo = 25000;
            trabajador1.Direccion = "Unah vs";
            trabajador1.EstadoCivilId = 2;
            trabajador1.CargoId = 1;
            trabajador1.MetodoPagoId = 1;
            trabajador1.JornadaId = 1;
            trabajador1.FechaInicio = new DateTime(2002, 4, 21);
            trabajador1.Cedula = 0512199700999;
            contexto.Trabajadores.Add(trabajador1);

            var trabajador2 = new Trabajador();
            trabajador2.Nombre = "German";
            trabajador2.Apellido = "Mendoza";
            trabajador2.Edad = 21;
            trabajador2.Sexo = sexo1;
            trabajador2.Sueldo = 25000;
            trabajador2.Direccion = "Unah vs";
            trabajador2.EstadoCivilId = 1;
            trabajador2.CargoId = 1;
            trabajador2.MetodoPagoId = 1;
            trabajador2.JornadaId = 1;
            trabajador2.FechaInicio = new DateTime(2002, 8, 20);
            trabajador2.Cedula = 0512199754885;
            contexto.Trabajadores.Add(trabajador2);

            var trabajador3 = new Trabajador();
            trabajador3.Nombre = "Juan";
            trabajador3.Apellido = "Alvarado";
            trabajador3.Edad = 24;
            trabajador3.Sexo = sexo1;
            trabajador3.Sueldo = 25000;
            trabajador3.Direccion = "Unah vs";
            trabajador3.EstadoCivilId = 1;
            trabajador3.CargoId = 1;
            trabajador3.MetodoPagoId = 1;
            trabajador3.JornadaId = 1;
            trabajador3.FechaInicio = new DateTime(2007, 1, 14);
            trabajador3.Cedula = 0512199778999;
            contexto.Trabajadores.Add(trabajador3);

            var trabajador4 = new Trabajador();
            trabajador4.Nombre = "Luis";
            trabajador4.Apellido = "Lopez";
            trabajador4.Edad = 45;
            trabajador4.Sexo = sexo1;
            trabajador4.Sueldo = 25000;
            trabajador4.Direccion = "Unah vs";
            trabajador4.EstadoCivilId = 1;
            trabajador4.CargoId = 1;
            trabajador4.MetodoPagoId = 1;
            trabajador4.JornadaId = 1;
            trabajador4.FechaInicio = new DateTime(2010, 11, 11);
            trabajador4.Cedula = 0512199707899;
            contexto.Trabajadores.Add(trabajador4);

            var trabajador5 = new Trabajador();
            trabajador5.Nombre = "Ariana";
            trabajador5.Apellido = "Mendoza";
            trabajador5.Edad = 26;
            trabajador5.Sexo = sexo2;
            trabajador5.Sueldo = 15000;
            trabajador5.Direccion = "Unah vs";
            trabajador5.EstadoCivilId = 1;
            trabajador5.CargoId = 2;
            trabajador5.MetodoPagoId = 1;
            trabajador5.JornadaId = 1;
            trabajador5.FechaInicio = new DateTime(2000, 6, 16);
            trabajador5.Cedula = 0512199499999;
            contexto.Trabajadores.Add(trabajador5);

            var trabajador6 = new Trabajador();
            trabajador6.Nombre = "Maria";
            trabajador6.Apellido = "Alvarez";
            trabajador6.Edad = 27;
            trabajador6.Sexo = sexo2;
            trabajador6.Sueldo = 12000;
            trabajador6.Direccion = "Unah vs";
            trabajador6.EstadoCivilId = 1;
            trabajador6.CargoId = 3;
            trabajador6.MetodoPagoId = 1;
            trabajador6.JornadaId = 2;
            trabajador6.FechaInicio = new DateTime(2018, 2, 14);
            trabajador6.Cedula = 0812199714999;
            contexto.Trabajadores.Add(trabajador6);


            var trabajador7 = new Trabajador();
            trabajador7.Nombre = "Doris";
            trabajador7.Apellido = "Perez";
            trabajador7.Edad = 26;
            trabajador7.Sexo = sexo3;
            trabajador7.Sueldo = 9800;
            trabajador7.Direccion = "Unah vs";
            trabajador7.EstadoCivilId = 1;
            trabajador7.CargoId = 4;
            trabajador7.MetodoPagoId = 1;
            trabajador7.JornadaId = 2;
            trabajador7.FechaInicio = new DateTime(2012, 7, 30);
            trabajador7.Cedula = 0912199712989;
            contexto.Trabajadores.Add(trabajador7);
            #endregion

            #region CAPACITACION
            var capacitacion1 = new Capacitacion();
            capacitacion1.Tema = "Manejo de Conflictos";
            capacitacion1.Horas = "12";
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

            #endregion

            base.Seed(contexto);
        }
    }
}
