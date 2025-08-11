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
    public partial class WebForm19 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            et_contract ct = new et_contract();
            ct.company_name = txtcm.Text;
            ct.company_address = txtcd.Text;
            ct.contact_person = txtcr.Text;
            ct.phone = txtpn.Text;
            ct.district = dt.SelectedItem.Text;
            ct.annual_turnover = txtan.Text;
            op_contract op = new op_contract();
            op.insert_contract(ct);
            txtcm.Text = "";
            txtcd.Text = "";
            txtcr.Text = "";
            txtpn.Text = "";
            txtan.Text = "";
           // Response.Write("<script>alert('done');</script>");
            Response.Redirect("view_complaint.aspx");
        }
    }
}