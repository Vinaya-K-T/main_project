using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DAL_potholedete.entities;
using BLL_potholedete.operation;
using pothole_detection_system.DB_conn;

namespace pothole_detection_system.userr
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        db_connection cn=new db_connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            RangeValidator1.MinimumValue=DateTime.Today.ToShortDateString();
            RangeValidator1.MaximumValue = "14-07-2025";
        }
        protected void Button1_Click(object sender, EventArgs e)
        {

            string upload = Request.PhysicalApplicationPath + "path_hole\\";
            string tname = txtlocn.Text.Substring(0, 3);
            string BTINMG;


            BTINMG = tname + ".jpg";

            if (img.HasFile)
            {
                img.SaveAs(upload + BTINMG);
            }


            et_complaint ec = new et_complaint();
            ec.location = txtlocn.Text;
            ec.subdate = txtsdt.Text;
            ec.description = txtdes.Text;
            ec.image = BTINMG;
            ec.status = "0";
            op_complaint op = new op_complaint();
            op.complaint_insert(ec);
            Response.Write("<script>alert('Success');</script>");
            txtlocn.Text = "";
            txtsdt.Text = "";
            txtdes.Text = "";
        }
    }
}