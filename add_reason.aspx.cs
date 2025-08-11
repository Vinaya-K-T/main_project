using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using pothole_detection_system.DB_conn;
using DAL_potholedete.entities;
using BLL_potholedete.operation;

namespace pothole_detection_system.Admins
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        db_connection cn=new db_connection();
         int i;
        protected void Page_Load(object sender, EventArgs e)
        {
        i=Convert.ToInt32(Request.QueryString[0]);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            cn.cmd = new SqlCommand("update budget set reason=@rn where bid=@id", cn.connect());
            cn.cmd.Parameters.AddWithValue("@rn",txtrn.Text);
            cn.cmd.Parameters.AddWithValue("@id", i);
            cn.cmd.ExecuteNonQuery();
            Response.Redirect("view_budget.aspx");
            txtrn.Text = "";
        }
           
    }
}