using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using pothole_detection_system.DB_conn;
using System.Data.SqlClient;
using DAL_potholedete.entities;
using BLL_potholedete.operation;

namespace pothole_detection_system.Admins
{
    public partial class WebForm21 : System.Web.UI.Page
    {
        db_connection cn=new db_connection();
        int ab = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            ab = Convert.ToInt32(Request.QueryString[0]);
            if (!IsPostBack)
            {
                cn.cmd = new SqlCommand("select * from contract", cn.connect());
                cn.cmd.Parameters.AddWithValue("@id", ab);
                cn.dr = cn.cmd.ExecuteReader();
                if (cn.dr.Read())
                {
                    txtcm.Text = cn.dr.GetString(1);
                    txtcd.Text= cn.dr.GetString(2);
                    txtcr.Text= cn.dr.GetString(3);
                    txtpn.Text= cn.dr.GetString(4);
                    dt.Text = cn.dr.GetString(5);
                    txtan.Text= cn.dr.GetString(6);
                    ts.Text= cn.dr.GetString(7);
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            et_contract ct = new et_contract();
            ct.company_name = txtcm.Text;
            ct.company_address = txtcd.Text;
            ct.contact_person = txtcr.Text;
            ct.phone = txtpn.Text;
            ct.district = dt.SelectedItem.Text;
            ct.annual_turnover = txtan.Text;
            op_contract op = new op_contract();
            op.update_contract(ct,ab);
            Response.Redirect("view_contracts.aspx");
        }
    }
}