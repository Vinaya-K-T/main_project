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
using System.Data;

namespace pothole_detection_system.contractor
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
        protected void Page_Load(object sender, EventArgs e)
        { 
            txtci.Text = Request.QueryString[0];
            RangeValidator1.MinimumValue = DateTime.Today.ToShortDateString();
            RangeValidator1.MaximumValue = "14-07-2025";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            et_budget eb = new et_budget();
            eb.project_phase = txtpp.Text;
            eb.complaint_name = txtcn.Text;
            eb.allocated_amount = txtam.Text;
            eb.expense_type = txtet.Text;
            eb.entry_date = txted.Text;
            eb.status = "";
            eb.cid = txtci.Text;
            eb.reason = "NULL";
            op_budget op = new op_budget();
            op.insert_budget(eb);
            Response.Write("<script>alert('success');</script>");
            Response.Redirect("view_complaints.aspx");
            txtcn.Text = "";
            txtpp.Text = "";
            txtam.Text = "";
            txtet.Text = "";
            txted.Text = "";
            txtci.Text = "";
        }

    }


}