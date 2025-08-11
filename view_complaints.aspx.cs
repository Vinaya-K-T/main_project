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

namespace pothole_detection_system.contractor
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
        protected void Page_Load(object sender, EventArgs e)
        {

            grid_data();
        }
        void grid_data()
        {
            cn.cmd = new SqlCommand("select * from complaint", cn.connect());
            DataTable dt = new DataTable();
            cn.dr = cn.cmd.ExecuteReader();
            dt.Columns.Add("#");
            dt.Columns.Add("Image");
            dt.Columns.Add("Location");
            dt.Columns.Add("Description");
            dt.Columns.Add("Status");
            dt.Columns.Add("Date");
            dt.Columns.Add("code");
            int count = 1;
            while (cn.dr.Read())
            {
                DataRow row = dt.NewRow();
                row["#"] = count;
                row["Image"] = cn.dr["image"];
                row["Location"] = cn.dr["location"];
                row["Description"] = cn.dr["description"];
                row["Status"] = cn.dr["status"];
                row["Date"] = cn.dr["subdate"];
                row["code"] = cn.dr["cid"];
                dt.Rows.Add(row);
                count++;
            }
            rptPathholes.DataSource = dt;
            rptPathholes.DataBind();
            
        }
        //protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        //{
        //    int i = Convert.ToInt32(e.CommandArgument);
        //    op_complaint op = new op_complaint();
        //    if (e.CommandName == "ad")
        //    {
        //        cn.cmd = new SqlCommand("update budget set allocated_amount=29 where bid=@id", cn.connect());
        //        cn.cmd.Parameters.AddWithValue("@id", i);
        //        cn.cmd.ExecuteNonQuery();
        //        Response.Redirect("add_budget.aspx");
        //    }
        //    if (e.CommandName == "com")
        //    {
        //        cn.cmd = new SqlCommand("UPDATE complaint SET status ='complete' WHERE cid = @id", cn.connect());
        //        cn.cmd.Parameters.AddWithValue("@id",1);
        //        cn.cmd.ExecuteNonQuery();
        //        Response.Redirect("view_complaints.aspx");
        //    }
        //}

        protected void rptPathholes_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            int i = Convert.ToInt32(e.CommandArgument);
            op_complaint op = new op_complaint();
            if (e.CommandName == "ad")
            {
                cn.cmd = new SqlCommand("update budget set allocated_amount=29 where bid=@id", cn.connect());
                cn.cmd.Parameters.AddWithValue("@id", i);
                cn.cmd.ExecuteNonQuery();
                Response.Redirect("add_budget.aspx");
            }
            if (e.CommandName == "com")
            {
                cn.cmd = new SqlCommand("UPDATE complaint SET status ='complete' WHERE cid = @id", cn.connect());
                cn.cmd.Parameters.AddWithValue("@id", 1);
                cn.cmd.ExecuteNonQuery();
                Response.Redirect("/Admin/view_complaint.aspx");
            }

        }
    }
}