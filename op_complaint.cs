using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_potholedete.DB_conn;
using DAL_potholedete.entities;
using System.Data.SqlClient;
using System.Data;


namespace BLL_potholedete.operation
{
    public class op_complaint
    {
        db_connection cn = new db_connection();
        public void complaint_insert(et_complaint etn)
        {
            cn.cmd = new SqlCommand("sp_complaint", cn.connect());
            cn.cmd.CommandType=CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@locn",etn.location);
            cn.cmd.Parameters.AddWithValue("@sdt",etn.subdate);
            cn.cmd.Parameters.AddWithValue("@des",etn.description);
            cn.cmd.Parameters.AddWithValue("@img",etn.image);
            cn.cmd.Parameters.AddWithValue("@st",etn.status);
            cn.cmd.Parameters.AddWithValue("@flag", 1);
            cn.cmd.Parameters.AddWithValue("@id", 1);
            cn.cmd.ExecuteNonQuery();
        }
        public void delete_complaint(int id)
        {
            cn.cmd = new SqlCommand("sp_complaint", cn.connect());
            cn.cmd.CommandType= CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@locn", "");
            cn.cmd.Parameters.AddWithValue("@sdt", "");
            cn.cmd.Parameters.AddWithValue("@des", "");
            cn.cmd.Parameters.AddWithValue("@img", "");
            cn.cmd.Parameters.AddWithValue("@st", "");
            cn.cmd.Parameters.AddWithValue("@flag",3);
            cn.cmd.Parameters.AddWithValue("@id", id);
            cn.cmd.ExecuteNonQuery();
        }
        public void update_complaint(et_complaint etn,int id)
        {
            cn.cmd = new SqlCommand("sp_complaint", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@locn", etn.location);
            cn.cmd.Parameters.AddWithValue("@sdt", etn.subdate);
            cn.cmd.Parameters.AddWithValue("@des", etn.description);
            cn.cmd.Parameters.AddWithValue("@img", etn.image);
            cn.cmd.Parameters.AddWithValue("@st", etn.status);
            cn.cmd.Parameters.AddWithValue("@flag",4 );
            cn.cmd.Parameters.AddWithValue("@id", id);
            cn.cmd.ExecuteNonQuery();
        }
    }
}
