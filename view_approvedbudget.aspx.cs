using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using pothole_detection_system.DB_conn;
using System.Data;
using BLL_potholedete.operation;
using System.Security.Cryptography;

namespace pothole_detection_system.Admins
{
    public partial class WebForm12 : System.Web.UI.Page
    {
        db_connection cn=new db_connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            grid_data();
        }
        void grid_data()
        {
            cn.cmd = new SqlCommand("select complaint.cid,complaint_name,project_phase,allocated_amount,budget.expense_type,entry_date,budget.status from complaint inner join budget on complaint.cid=budget.cid", cn.connect());
            DataTable dt = new DataTable();
            cn.dr = cn.cmd.ExecuteReader();
            dt.Columns.Add("#");
            dt.Columns.Add("Project Phase");
            dt.Columns.Add("Complaint Name");
            dt.Columns.Add("Allocated Amount");
            dt.Columns.Add("Expense Type");
            dt.Columns.Add("Entry Date");
            dt.Columns.Add("Status");
            int count = 1;
            while (cn.dr.Read())
            {
                DataRow row = dt.NewRow();
                row["#"] = cn.dr["cid"];
                row["Project Phase"] = cn.dr["project_phase"];
                row["Complaint Name"] = cn.dr["complaint_name"];
                row["Allocated Amount"] = cn.dr["allocated_amount"];
                row["Expense Type"] = cn.dr["expense_type"];
                row["Entry Date"] = cn.dr["entry_date"];
                row["Status"] = cn.dr["status"];
                dt.Rows.Add(row);
                count++;
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int i = Convert.ToInt32(e.CommandArgument);
            if (e.CommandName == "ad")
            {
                Response.Redirect("add_balance.aspx?a=" + GridView1.Rows[i].Cells[4].Text + "&b=" + GridView1.Rows[i].Cells[1].Text);
            }
        }
    }
}
