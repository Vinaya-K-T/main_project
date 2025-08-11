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
    public partial class WebForm18 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
        int ab = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            ab = Convert.ToInt32(Request.QueryString[0]);
            if(!IsPostBack)
            {
                cn.cmd = new SqlCommand("select * from potholedetect where pid=@id", cn.connect());
                cn.cmd.Parameters.AddWithValue("@id", ab);
                cn.dr=cn.cmd.ExecuteReader();
                if(cn.dr.Read())
                { 
                    txtloc.Text = cn.dr.GetString(1);
                    txtdes.Text = cn.dr.GetString(2);
                    st.Text = cn.dr.GetString(3);
                    txtui.Text=cn.dr.GetValue(4).ToString();
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            et_potholedetect p=new et_potholedetect();
            p.location=txtloc.Text;
            p.description= txtdes.Text;
            p.status = st.Text;
            p.uid =txtui.Text;
            op_potholedetect op = new op_potholedetect();
            op.update_potholedetect(p, ab);
            Response.Redirect("view_potholedetect.aspx");
        }
    }
}