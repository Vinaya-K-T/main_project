using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using pothole_detection_system.DB_conn;
using System.Data;
using BLL_potholedete.operation;

namespace pothole_detection_system.Admins
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            grid_data();
        }
        void grid_data()
        {
            cn.da = new SqlDataAdapter("select * from detection", cn.connect());
            DataTable dt = new DataTable();
            cn.da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}