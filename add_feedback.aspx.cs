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

namespace pothole_detection_system.userr
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            txtui.Text = Session["uname"].ToString();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            et_feedback ef = new et_feedback();
            ef.email = txtem.Text;
            ef.message = txtmsg.Text;
            ef.submission_date = txtsub.Text;
            ef.uid = txtui.Text;
            op_feedback op = new op_feedback();
            op.feedback_insert(ef);
            Response.Write("<script>alert('Done!');</script>");
            // Response.Redirect("/Admins/view_feedback.aspx");
            txtem.Text = "";
            txtmsg.Text = "";
            txtsub.Text = "";
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

        }
    }
}