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
    public partial class WebForm11 : System.Web.UI.Page
    {
        db_connection cn=new db_connection();
        string ab;
        protected void Page_Load(object sender, EventArgs e)
        {
            ab = Request.QueryString[0];
            txtam.Text = ab;
            txtci.Text = Request.QueryString[1];
        }

        protected void Button1_Click(object sender, EventArgs e)
        { 
            et_balance b=new et_balance();
            b.allocated_amount=txtam.Text;
            b.spend_amount=txtsa.Text;
            b.date=txtdt.Text;
            b.cid=txtci.Text;
            op_balance op = new op_balance();
            op.insert_balance(b);
            Response.Write("<script>alert('success');</script>");
            txtam.Text = "";
            txtsa.Text = "";
            txtdt.Text = "";
            txtci.Text = "";
        }
    }
}