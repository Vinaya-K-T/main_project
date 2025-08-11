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
    public partial class WebForm20 : System.Web.UI.Page
    {
        db_connection cn=new db_connection();
     
        protected void Page_Load(object sender, EventArgs e)
        {
            
            grid_data();
        }
        void grid_data()
        {
            cn.cmd = new SqlCommand("select * from contract", cn.connect());
            DataTable dt = new DataTable();
            cn.dr = cn.cmd.ExecuteReader();
            dt.Columns.Add("#");
            dt.Columns.Add("Company Name");
            dt.Columns.Add("Company Address");
            dt.Columns.Add("Contact Person");
            dt.Columns.Add("Phone");
            dt.Columns.Add("District");
            dt.Columns.Add("Annual Turnover");
            int count = 1;
            while (cn.dr.Read())
            {
                DataRow row = dt.NewRow();
                row["#"] = cn.dr["tid"];
                row["Company Name"] = cn.dr["company_name"];
                row["Company Address"] = cn.dr["company_address"];
                row["Contact Person"] = cn.dr["contact_person"];
                row["Phone"] = cn.dr["phone"];
                row["District"] = cn.dr["district"];
                row["Annual Turnover"] = cn.dr["annual_turnover"];
                dt.Rows.Add(row);
                count++;
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int i=Convert.ToInt32(e.CommandArgument);
            op_contract op=new op_contract();
            if(e.CommandName =="del")
            {
                op.delete_contract(Convert.ToInt32(GridView1.Rows[i].Cells[3].Text));
                grid_data();
            }
            if(e.CommandName =="upd")
            {
                Response.Redirect("upd_contracts.aspx?a=" + GridView1.Rows[i].Cells[3].Text);
            }
            if (e.CommandName == "ch")
            {
                cn.cmd = new SqlCommand("UPDATE complaint SET status ='assigned' WHERE cid = @id", cn.connect());
                cn.cmd.Parameters.AddWithValue("@id", i);
                cn.cmd.ExecuteNonQuery();
                Response.Redirect("/contractor/view_complaints.aspx?a=" + GridView1.Rows[i].Cells[4].Text);
            }
           
        }
    }
}