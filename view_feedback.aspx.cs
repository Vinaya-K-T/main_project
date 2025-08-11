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
    public partial class WebForm8 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            grid_data();
        }
        void grid_data()
        {
            //cn.da = new SqlDataAdapter("select * from feedback", cn.connect());
            //DataTable dt= new DataTable();
            //cn.da.Fill(dt);
            //GridView1.DataSource = dt;
            //GridView1.DataBind();

            cn.cmd = new SqlCommand("select * from feedback", cn.connect());
            DataTable dt = new DataTable();
            cn.dr=cn.cmd.ExecuteReader();
                dt.Columns.Add("#");
                dt.Columns.Add("Email");
                dt.Columns.Add("Message");
                dt.Columns.Add("Submission Date");
                int count = 1;
                while(cn.dr.Read())
                {
                    DataRow row = dt.NewRow();
                    row["#"] = cn.dr["fid"];
                    row["Email"] = cn.dr["Email"];
                    row["Message"]=cn.dr["Message"];
                    row["Submission Date"] = cn.dr["submission_date"];
                    dt.Rows.Add(row);
                    count++;
                }
                GridView1.DataSource = dt;
                GridView1.DataBind();
        }
        protected void GridView1_RowCommand(object sender , CommandEventArgs e)
        {
            int i= Convert.ToInt32(e.CommandArgument);
            op_feedback op=new op_feedback();
            if (e.CommandName=="del")
            {
                op.delete_feedback(Convert.ToInt32(GridView1.Rows[i].Cells[2].Text));
                grid_data();
            }
            if(e.CommandName=="upd")
            {
                Response.Redirect("upd_feedback.aspx?a=" + GridView1.Rows[i].Cells[2].Text);

            }
        }
    }
}