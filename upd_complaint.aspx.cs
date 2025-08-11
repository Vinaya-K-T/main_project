using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using pothole_detection_system.DB_conn;
using System.Data.SqlClient;
using DAL_potholedete.entities;
using BLL_potholedete.operation;

namespace pothole_detection_system.Admins
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        db_connection cn=new db_connection();
        int ab = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
        ab=Convert.ToInt32(Request.QueryString[0]);
        if(!IsPostBack)
            {
                cn.cmd = new SqlCommand("select * from complaint where cid=@id", cn.connect());
                cn.cmd.Parameters.AddWithValue("@id", ab);
                cn.dr=cn.cmd.ExecuteReader();
                if(cn.dr.Read())
                {
                    txtlocn.Text=cn.dr.GetString(3);
                    txtsdt.Text=cn.dr.GetString(4);
                    txtdes.Text=cn.dr.GetString(5);
                   sts.SelectedItem.Text=cn.dr.GetString(6);
                    //id.Text = cn.dr.GetValue(7).ToString();

                }
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            et_complaint ec = new et_complaint();
            
            ec.location = txtlocn.Text;
            ec.subdate = txtsdt.Text;
            ec.description = txtdes.Text;
            ec.image = img.FileName.ToString();
            ec.status = sts.SelectedItem.Text;
           // ec.pid = id.Text;
            op_complaint op = new op_complaint();
            op.update_complaint(ec, ab);
            Response.Redirect("view_complaint.aspx");
        }
    }
}