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
        private SqlConnection conexion = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = RRHHDB; Integrated Security = true");
        private DataSet ds;

        public DataTable MostrarDatos()
        {
            conexion.Open();
            SqlCommand cmd = new SqlCommand("select * from Trabajador", conexion);
            //SqlCommand cmd2 = new SqlCommand("SELECT dbo.Cargo.Id, dbo.Cargo.Descripcion FROM dbo.Cargo INNER JOIN dbo.Trabajador ON dbo.Cargo.Id = dbo.Trabajador.CargoId", conexion);
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
            SqlCommand cmd = new SqlCommand(string.Format("select * from Trabajador where Nombre like '%{0}%'", nombre), conexion);
            SqlCommand cmd2 = new SqlCommand(string.Format("select * from Trabajador where Apellido like '%{0}%'", apellido), conexion);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            SqlDataAdapter ad2 = new SqlDataAdapter(cmd2);
            ds = new DataSet();
            ad.Fill(ds, "tabla");
            ad2.Fill(ds, "tabla");
            conexion.Close();
            return ds.Tables["tabla"];
        }
    }
}
