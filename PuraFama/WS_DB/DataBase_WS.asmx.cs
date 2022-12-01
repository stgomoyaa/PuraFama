using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WS_DB
{
    /// <summary>
    /// Descripción breve de DataBase_WS
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class DataBase_WS : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }

        [WebMethod]
        public DataSet ListarCliente()
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source = DESKTOP-GPLOCHV; Initial Catalog=bd_seguidores; Integrated Security=True;";
            SqlDataAdapter data = new SqlDataAdapter("SELECT * FROM CLIENTE", conn);
            DataSet ds = new DataSet();
            data.Fill(ds);
            return ds;
        }

        [WebMethod]
        public DataSet CrearCliente(int rut, string nombre, int telefono, int gastos)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source = DESKTOP-GPLOCHV; Initial Catalog=bd_seguidores; Integrated Security=True;";
            SqlDataAdapter data = new SqlDataAdapter("exec CrearCliente " + rut + "," + nombre + "," + telefono + "," + gastos, conn);
            DataSet ds = new DataSet();
            data.Fill(ds);
            return ds;
        }

        [WebMethod]
        public DataSet LeerCliente(int rut)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source = DESKTOP-GPLOCHV; Initial Catalog=bd_seguidores; Integrated Security=True;";
            SqlDataAdapter data = new SqlDataAdapter("exec LeerCliente " + rut, conn);
            DataSet ds = new DataSet();
            data.Fill(ds);
            return ds;
        }

        [WebMethod]
        public DataSet ActualizarCliente(int rut, string nombre, int telefono, int gastos)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source = DESKTOP-GPLOCHV; Initial Catalog=bd_seguidores; Integrated Security=True;";
            SqlDataAdapter data = new SqlDataAdapter("exec ActualizarCliente " + rut + "," + nombre + "," + telefono + "," + gastos, conn);
            DataSet ds = new DataSet();
            data.Fill(ds);
            return ds;
        }

        [WebMethod]
        public DataSet EliminarCliente(int rut)
        {
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = "Data Source = DESKTOP-GPLOCHV; Initial Catalog=bd_seguidores; Integrated Security=True;";
            SqlDataAdapter data = new SqlDataAdapter("exec EliminarCliente " + rut, conn);
            DataSet ds = new DataSet();
            data.Fill(ds);
            return ds;
        }
    }
}
