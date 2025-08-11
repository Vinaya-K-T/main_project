using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using pothole_detection_system.DB_conn;

namespace pothole_detection_system.contractor
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            string s = Request.QueryString[0];
            cn.cmd = new SqlCommand("UPDATE complaint SET status ='complete' WHERE cid = @id", cn.connect());
            cn.cmd.Parameters.AddWithValue("@id", s);
            cn.cmd.ExecuteNonQuery();
            Response.Redirect("view_complaints.aspx");
        }
    }
}