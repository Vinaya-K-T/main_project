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
    public partial class WebForm3 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
         
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender,EventArgs e)
        {
            et_complaint c=new et_complaint();
            c.location=txtlocn.Text;
            c.subdate=txtsdt.Text;
            c.description = txtdes.Text;
            c.image = img.FileName.ToString();
            c.status = sts.SelectedItem.Text;
           // c.pid = id.Text;
            op_complaint op = new op_complaint();
            op.complaint_insert(c);
            Response.Write("<script>alert('done');</script>");
        }
    }
}