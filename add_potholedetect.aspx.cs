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
    public partial class WebForm15 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            et_potholedetect p = new et_potholedetect();
            p.image = img.FileName.ToString();
            p.location = txtloc.Text;
            p.description = txtdes.Text;
            p.status = st.Text;
            p.uid = txtui.Text;
            op_potholedetect op = new op_potholedetect();
            op.insert_potholedetect(p);
            Response.Write("<script>alert('done');</script>");
        }
    }
}