using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using pothole_detection_system.DB_conn;
using BLL_potholedete.operation;
using System.Data;

namespace pothole_detection_system.Admins
{
    public partial class WebForm17 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            grid_data();
        }
        void grid_data()
        {
            //cn.da = new SqlDataAdapter("select * from potholedetect", cn.connect());
            //DataTable dt = new DataTable();
            //cn.da.Fill(dt);
            //GridView1.DataSource = dt;
            //GridView1.DataBind();

            cn.cmd = new SqlCommand("select * from potholedetect", cn.connect());
            DataTable dt = new DataTable();
            cn.dr=cn.cmd.ExecuteReader();
                dt.Columns.Add("#");
                dt.Columns.Add("Image");
                dt.Columns.Add("Location");
                dt.Columns.Add("Description");
                dt.Columns.Add("Status");
                 int count = 1;
                while (cn.dr.Read())
                {
                    DataRow row= dt.NewRow();
                    row["#"]=cn.dr["pid"];
                    row["Image"] = cn.dr["Image"];
                    row["Location"] = cn.dr["Location"];
                    row["Description"]=cn.dr["Description"];
                    row["Status"] = cn.dr["Status"];
                    dt.Rows.Add(row);
                    count++;
                }
                GridView1.DataSource = dt;
                GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
        int i=Convert.ToInt32(e.CommandArgument);
            op_potholedetect op = new op_potholedetect();
            if(e.CommandName =="del")
            {
                op.delete_potholedetect(Convert.ToInt32(GridView1.Rows[i].Cells[2].Text));
                grid_data();
            }
            if(e.CommandName =="upd")
            {
                Response.Redirect("upd_potholedetect.aspx?a="+ GridView1.Rows[i].Cells[2].Text);
            }
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}