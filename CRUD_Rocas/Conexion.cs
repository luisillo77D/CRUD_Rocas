using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Rocas
{
    public class Conexion
    {
        public SqlConnection conn;
       public Conexion()
        {
            conn = new SqlConnection();
            conn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\luisi\\source\\repos\\CRUD_Rocas\\CRUD_Rocas\\DBLaboGeociencias.mdf;Integrated Security=True=";
        }
         
    }
}
