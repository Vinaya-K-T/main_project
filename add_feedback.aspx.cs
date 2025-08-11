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
    public partial class WebForm4 : System.Web.UI.Page
    {
        db_connection cn= new db_connection();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            et_feedback f= new et_feedback();
            f.email=txteml.Text;
            f.message=txtmsg.Text;
            f.submission_date=txtsub.Text;
            //f.uid=ui.Text;
            op_feedback op=new op_feedback();
            op.feedback_insert(f);
            Response.Write("<script>alert('done!');</script>");
            txteml.Text = "";
            txtmsg.Text = "";
            txtsub.Text = "";
        }
    }
}