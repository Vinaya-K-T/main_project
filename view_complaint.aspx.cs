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

namespace pothole_detection_system.Admins
{
    public partial class WebForm6 : System.Web.UI.Page
    {
     db_connection cn= new db_connection();
    
        protected void Page_Load(object sender, EventArgs e)
        {
            cn.cmd = new SqlCommand("select count(*) from complaint where status='complete'", cn.connect());
            string ss = cn.cmd.ExecuteScalar().ToString();
            lblc.Text = ss;

            cn.cmd = new SqlCommand("select count(*) from complaint where status<>'complete'", cn.connect());
            string sd = cn.cmd.ExecuteScalar().ToString();
            lblnc.Text = sd;



            reapter_data();
          //  grid_data();
        }
        void grid_data()
        {
           

            //cn.cmd = new SqlCommand("select * from complaint", cn.connect());
            //DataTable dt = new DataTable();
            //cn.dr = cn.cmd.ExecuteReader();
            //{
            //    dt.Columns.Add("#");
            //    dt.Columns.Add("Name");
            //    dt.Columns.Add("Email");
            //    dt.Columns.Add("Location");
            //    dt.Columns.Add("Submission Date");
            //    dt.Columns.Add("Description");
            //    dt.Columns.Add("Image");
            //    dt.Columns.Add("Status");
            //    dt.Columns.Add("p_id");
            //    int count = 1;
            //    while (cn.dr.Read())
            //    {
            //        DataRow row = dt.NewRow();
            //        row["#"] = cn.dr["cid"];
            //        row["Name"] = cn.dr["Name"];
            //        row["Email"] = cn.dr["Email"];
            //        row["Location"] = cn.dr["Location"];
            //        row["Submission Date"] = cn.dr["SubDate"];
            //        row["Description"] = cn.dr["Description"];
            //        row["Image"] = cn.dr["Image"];
            //        row["Status"] = cn.dr["Status"];
            //        row["p_id"] = cn.dr["pid"];
            //        dt.Rows.Add(row);
            //        count++;
            //    }
            //    GridView1.DataSource = dt;
            //    GridView1.DataBind();
            
        }

        void reapter_data()
        {
            //cn.da = new SqlDataAdapter("select * from potholedetect", cn.connect());
            //DataTable dt = new DataTable();
            //cn.da.Fill(dt);
            //GridView1.DataSource = dt;
            //GridView1.DataBind();

            cn.cmd = new SqlCommand("select * from complaint", cn.connect());
            DataTable dt = new DataTable();
            cn.dr = cn.cmd.ExecuteReader();
            dt.Columns.Add("#");
            dt.Columns.Add("Image");
            dt.Columns.Add("Location");
            dt.Columns.Add("Description");
            dt.Columns.Add("Date");
            dt.Columns.Add("code");
            //dt.Columns.Add("Status");
            int count = 1;
            while (cn.dr.Read())
            {
                DataRow row = dt.NewRow();
                row["#"] = cn.dr["cid"];
                row["Image"] = cn.dr["image"];
                row["Location"] = cn.dr["location"];
                row["Description"] = cn.dr["description"];
                row["Date"] = cn.dr["subdate"];
                row["Image"] = cn.dr["image"];
                //row["Status"] = cn.dr["status"];
                dt.Rows.Add(row);
                count++;
            }
            rptPathholes.DataSource = dt;
            rptPathholes.DataBind();
            // GridView1.DataSource = dt;
            //GridView1.DataBind();


        }

        //protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        //{
        //    int i = Convert.ToInt32(e.CommandArgument); 
        //    op_complaint op = new op_complaint();
        //    if (e.CommandName == "ass")
        //    {
        //        Response.Redirect("add_contracts.aspx?a=" + GridView1.Rows[i].Cells[1].Text);
        //    }
       // }
    }
}