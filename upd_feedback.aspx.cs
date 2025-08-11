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
    public partial class WebForm9 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
        int ab = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            ab = Convert.ToInt32(Request.QueryString[0]);
            if(!IsPostBack)
            {
                cn.cmd = new SqlCommand("select * from feedback where fid=@id", cn.connect());
                cn.cmd.Parameters.AddWithValue("@id", ab);
                cn.dr=cn.cmd.ExecuteReader();
                if(cn.dr.Read())
                {
                    txteml.Text = cn.dr.GetString(1);
                    txtmsg.Text = cn.dr.GetString(2);
                    txtsub.Text = cn.dr.GetString(3);
                    //ui.Text = cn.dr.GetValue(4).ToString() ;
                }
            }
        }
       
        protected void Button1_Click(object sender, EventArgs e)
        {

            et_feedback f = new et_feedback();
            f.email = txteml.Text;
            f.message = txtmsg.Text;
            f.submission_date = txtsub.Text;
           // f.uid=ui.Text;
            op_feedback op = new op_feedback();
            op.update_feedback(f, ab);
            Response.Redirect("view_feedback.aspx");
        }
    }
}