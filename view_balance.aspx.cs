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
    public partial class WebForm6 : System.Web.UI.Page
    {
        db_connection cn = new db_connection();
        protected void Page_Load(object sender, EventArgs e)
        {
            grid_data();
        }
        void grid_data()
        {
            cn.cmd = new SqlCommand("select * from balance", cn.connect());
            DataTable dt = new DataTable();
            cn.dr = cn.cmd.ExecuteReader();
            dt.Columns.Add("#");
            dt.Columns.Add("Allocated Amount");
            dt.Columns.Add("Spend Amount");
            dt.Columns.Add("Date");
            int count = 1;
            while (cn.dr.Read())
            {
                DataRow row = dt.NewRow();
                row["#"] = cn.dr["mid"];
                row["Allocated Amount"] = cn.dr["allocated_amount"];
                row["Spend Amount"] = cn.dr["spend_amount"];
                row["Date"] = cn.dr["date"];
                dt.Rows.Add(row);
                count++;
            }
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}