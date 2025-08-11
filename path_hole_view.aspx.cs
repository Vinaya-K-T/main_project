using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using pothole_detection_system.DB_conn;

namespace pothole_detection_system.userr
{
    public partial class WebForm11 : System.Web.UI.Page
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

            cn.cmd = new SqlCommand("select * from complaint", cn.connect());
            DataTable dt = new DataTable();
            cn.dr = cn.cmd.ExecuteReader();
            dt.Columns.Add("#");
            dt.Columns.Add("Image");
            dt.Columns.Add("Location");
            dt.Columns.Add("Description");
            dt.Columns.Add("Status");
            dt.Columns.Add("Date");
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
                dt.Rows.Add(row);
                count++;
            }
            rptPathholes.DataSource = dt;
            rptPathholes.DataBind();
        }

    }
}