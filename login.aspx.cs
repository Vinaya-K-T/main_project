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

namespace pothole_detection_system.login_public
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string role;
        db_connection cn=new db_connection();
        op_login op=new op_login();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cn.cmd = new SqlCommand("select * from login where uname=@uname and password=@pass", cn.connect());
            cn.cmd.Parameters.AddWithValue("@uname", txtun.Text);
            cn.cmd.Parameters.AddWithValue("@pass", txtpwd.Text);
            SqlDataReader rdr = cn.cmd.ExecuteReader();
            if (rdr.Read())
            {


                Session["uname"] = txtun.Text;


                role = rdr.GetString(3);

                if (role == "admin")
                {
                    Response.Redirect("../Admins/view_complaint.aspx");
                }
                else if (role == "user")
                {

                    Response.Redirect("../userr/add_complaint.aspx");

                }
                else if (role == "contractor")
                {
                    Response.Redirect("../contractor/View_complaints.aspx");
                }
                else
                {
                    //Response.Redirect("Login.aspx");
                    Response.Write("<script>alert('No user exist');</script>");
                }
            }
            else
            {
                // Response.Redirect("Login.aspx");
                Response.Write("<script>alert('Error in login details. please check it');</script>");
            }
        }
    }
}