using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RRHH.BL
{
    public class BusquedaBL
    {
        private SqlConnection conexion = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = RRHH; Integrated Security = true");
        private DataSet ds;

        public DataTable MostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select Nombre, Apellido,Cedula, Edad, Direccion, Sueldo, FechaInicio, Sexo.Descripcion as Sexo, Cargo.Descripcion as Cargo, Jornada.Descripcion as Jornada, EstadoCivil.Descripcion as Estado_Civil from Trabajador, Cargo, Jornada, EstadoCivil, Sexo where Trabajador.CargoId = Cargo.Id  and Trabajador.JornadaId = Jornada.Id and Trabajador.EstadoCivilId = EstadoCivil.Id and Trabajador.SexoId = Sexo.Id", conexion);
            //SqlCommand cmd2 = new SqlCommand("SELECT dbo.Cargo.Id, dbo.Cargo.Descripcion FROM dbo.Cargo INNER JOIN dbo.Trabajador ON dbo.Cargo.Id = dbo.Trabajador.CargoId", conexion);
            //SqlCommand cmd2 = new SqlCommand("select ", conexion);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            //SqlDataAdapter ad2 = new SqlDataAdapter(cmd2);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            //ad2.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }

        public DataTable Buscar(string nombre, string apellido)
        {
            conexion.Open();
            //SqlCommand cmd = new SqlCommand(string.Format("select Nombre, Apellido, Descripcion from Trabajador inner join Cargo on Trabajador.CargoId = Cargo.Id where Nombre like " + "'" + nombre + "'" + "and apellido like " + "'"+ apellido + "'"), conexion);

            SqlCommand cmd = new SqlCommand(string.Format("select Nombre, Apellido,Cedula, Edad, Direccion, Sueldo, FechaInicio, Sexo.Descripcion as Sexo, Cargo.Descripcion as Cargo, Jornada.Descripcion as Jornada, EstadoCivil.Descripcion as Estado_Civil from Trabajador, Cargo, Jornada, EstadoCivil, Sexo where Trabajador.CargoId = Cargo.Id  and Trabajador.JornadaId = Jornada.Id and Trabajador.EstadoCivilId = EstadoCivil.Id and Trabajador.SexoId = Sexo.Id and Nombre like '%{0}%'", nombre), conexion);
            SqlCommand cmd2 = new SqlCommand(string.Format("select Nombre, Apellido,Cedula, Edad, Direccion, Sueldo, FechaInicio, Sexo.Descripcion as Sexo, Cargo.Descripcion as Cargo, Jornada.Descripcion as Jornada, EstadoCivil.Descripcion as Estado_Civil from Trabajador, Cargo, Jornada, EstadoCivil, Sexo where Trabajador.CargoId = Cargo.Id  and Trabajador.JornadaId = Jornada.Id and Trabajador.EstadoCivilId = EstadoCivil.Id and Trabajador.SexoId = Sexo.Id and Apellido like '%{0}%'", apellido), conexion);
            //SqlCommand cmd3 = new SqlCommand(string.Format("select Nombre, Apellido, Descripcion from Trabajador inner join Cargo on Trabajador.CargoId = Cargo.Id where descripcion like '%{0}%'", descripcion), conexion);

            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataAdapter ad2 = new SqlDataAdapter(cmd2);
            //SqlDataAdapter ad3 = new SqlDataAdapter(cmd3);

            ds = new DataSet();
            ad.Fill(ds, "tabla");
            ad2.Fill(ds, "tabla");
            //ad3.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
        public DataTable Buscar2(string descripcion)
        {
            conexion.Open();
            //SqlCommand cmd = new SqlCommand(string.Format("select Nombre, Apellido, Descripcion from Trabajador inner join Cargo on Trabajador.CargoId = Cargo.Id where Nombre like '%{0}%'", nombre), conexion);
            //SqlCommand cmd2 = new SqlCommand(string.Format("select Nombre, Apellido, Descripcion from Trabajador inner join Cargo on Trabajador.CargoId = Cargo.Id where Apellido like '%{0}%'", apellido), conexion);
            SqlCommand cmd3 = new SqlCommand(string.Format("select Nombre, Apellido,Cedula, Edad, Direccion, Sueldo, FechaInicio, Sexo.Descripcion as Sexo, Cargo.Descripcion as Cargo, Jornada.Descripcion as Jornada, EstadoCivil.Descripcion as Estado_Civil from Trabajador, Cargo, Jornada, EstadoCivil, Sexo where Trabajador.CargoId = Cargo.Id  and Trabajador.JornadaId = Jornada.Id and Trabajador.EstadoCivilId = EstadoCivil.Id and Trabajador.SexoId = Sexo.Id and Cargo.Descripcion like '%{0}%'", descripcion), conexion);

            //SqlDataAdapter ad = new SqlDataAdapter(cmd)
            //SqlDataAdapter ad2 = new SqlDataAdapter(cmd2);
            SqlDataAdapter ad3 = new SqlDataAdapter(cmd3);
            ds = new DataSet();
            //ad.Fill(ds, "tabla");
            //ad2.Fill(ds, "tabla");
            ad3.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
    }
}
