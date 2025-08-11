using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_potholedete.DB_conn
{
    public class db_connection
    {
        public SqlConnection conn;
        public SqlCommand cmd;

        public SqlConnection connect()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-7JFJ80D;Initial Catalog=pothole_detection;Integrated Security=True;");
            conn.Open();

            return conn;
        }
    }
}
