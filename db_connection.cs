using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using pothole_detection_system.DB_conn;

namespace pothole_detection_system.DB_conn
{
    public class db_connection
    {
        public SqlConnection conn;
        public SqlCommand cmd;
        public SqlDataAdapter da;
        public SqlDataReader dr;

        public SqlConnection connect()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-7JFJ80D;Initial Catalog=pothole_detection;Integrated Security=True;");
            conn.Open();
            return conn;
        }
    }
}