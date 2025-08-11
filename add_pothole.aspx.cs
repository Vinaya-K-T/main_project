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
    public partial class WebForm5 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
        protected void Page_Load(object sender, EventArgs e)
        {
        txtui.Text= Session["uname"].ToString();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            et_potholedetect d = new et_potholedetect();
            d.image = img.FileName.ToString();
            d.location = txtloc.Text;
            d.description = txtdes.Text;
            d.status = txtst.SelectedItem.Text; ;
            //d.uid = txtui.Text;
            op_potholedetect op = new op_potholedetect();
            op.insert_potholedetect(d);
            Response.Write("<script>alert('done');</script>");
            txtloc.Text = "";
            txtdes.Text = "";
            txtst.Text = "";
            txtui.Text = "";
        }
    }
}