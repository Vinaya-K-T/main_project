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
    public partial class WebForm22 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
        //string bid;

        protected void Page_Load(object sender, EventArgs e)
        {
            //bid = Request.QueryString[0];
            grid_data();
        }

        void grid_data()
        {
            cn.cmd = new SqlCommand("select * from budget", cn.connect());
            DataTable dt = new DataTable();
            cn.dr = cn.cmd.ExecuteReader();
            dt.Columns.Add("#");
            dt.Columns.Add("Project Phase");
            dt.Columns.Add("Complaint Name");
            dt.Columns.Add("Allocated Amount");
            dt.Columns.Add("Expense Type");
            dt.Columns.Add("Entry Date");
            dt.Columns.Add("Status");
            dt.Columns.Add("Reason");
            //dt.Columns.Add("cid");
            int count = 1;
            while (cn.dr.Read())
            {
                DataRow row = dt.NewRow();
                row["#"] = cn.dr["bid"];
                row["Project Phase"] = cn.dr["project_phase"];
                row["Complaint Name"] = cn.dr["complaint_name"];
                row["Allocated Amount"] = cn.dr["allocated_amount"];
                row["Expense Type"] = cn.dr["expense_type"];
                row["Entry Date"] = cn.dr["entry_date"];
                row["Status"] = cn.dr["status"].ToString();
                //string st = cn.dr["status"].ToString();
                row["Reason"] = cn.dr["reason"];
                //row["cid"] = cn.dr["cid"];
                dt.Rows.Add(row);
                count++;
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }



        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int i = Convert.ToInt32(e.CommandArgument);
            op_budget op = new op_budget();
            if (e.CommandName == "app")
            {
                cn.cmd = new SqlCommand("UPDATE budget SET status ='approve' WHERE bid = @id", cn.connect());
                cn.cmd.Parameters.AddWithValue("@id", GridView1.Rows[i].Cells[2].Text);
                cn.cmd.ExecuteNonQuery();
               Response.Redirect("add_reason.aspx?a=" + GridView1.Rows[i].Cells[2].Text);
            }
            if (e.CommandName == "rej")
            {
                cn.cmd = new SqlCommand("UPDATE budget SET status ='reject' WHERE bid = @id", cn.connect());
                cn.cmd.Parameters.AddWithValue("@id", GridView1.Rows[i].Cells[2].Text);
                cn.cmd.ExecuteNonQuery();
                Response.Redirect("add_reason.aspx?a=" + GridView1.Rows[i].Cells[2].Text);

            }
        }
    }
}
