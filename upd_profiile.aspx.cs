using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using pothole_detection_system.DB_conn;
using DAL_potholedete.entities;
using BLL_potholedete.operation;

namespace pothole_detection_system.userr
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
        string ab;
        protected void Page_Load(object sender, EventArgs e)
        {
            //ab = Convert.ToInt32(Request.QueryString[0]);
            ab = Session["uname"].ToString();
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
                    txtpswd.Text = cn.dr.GetString(4);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            et_register er= new et_register();
            er.name=txtfn.Text; 
            er.phone=txtpno.Text;
            er.email=txtem.Text;
            er.password=txtpswd.Text;
            er.uname = ab;
            op_register op= new op_register();
            op.update_register(er,4);
            Response.Redirect("view_profiile.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("view_profiile.aspx");
        }
    }
}