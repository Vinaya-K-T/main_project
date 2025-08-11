using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using pothole_detection_system.DB_conn;

using System.Data.SqlClient;

namespace pothole_detection_system.userr
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
        string ab;
        protected void Page_Load(object sender, EventArgs e)
        {
            //ab = Convert.ToInt32(Request.QueryString[0]);
            string ab = Session["uname"].ToString();
            if (!IsPostBack)
            {
                cn.cmd = new SqlCommand("select * from register where uname=@un", cn.connect());
                cn.cmd.Parameters.AddWithValue("@un", ab);
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.Read())
                {
                    txtfn.Text = cn.dr.GetString(1);
                    txtpno.Text = cn.dr.GetString(2);
                    txtem.Text = cn.dr.GetString(3);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("upd_profiile.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}