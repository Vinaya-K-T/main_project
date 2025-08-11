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
    public class op_potholedetect
    {
        db_connection cn = new db_connection();
        public void insert_potholedetect(et_potholedetect etn)
        {
            cn.cmd = new SqlCommand("sp_potholedetect", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@img", etn.image);
            cn.cmd.Parameters.AddWithValue("@loc",etn.location);
            cn.cmd.Parameters.AddWithValue("@des",etn.description);
            cn.cmd.Parameters.AddWithValue("@st",etn.status);
            cn.cmd.Parameters.AddWithValue("@ui", etn.uid);
            cn.cmd.Parameters.AddWithValue("@id", 1);
            cn.cmd.Parameters.AddWithValue("@flag",1);
            cn.cmd.ExecuteNonQuery();
        }
        public void delete_potholedetect(int id)
        {
            cn.cmd = new SqlCommand("sp_potholedetect", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@img", "");
            cn.cmd.Parameters.AddWithValue("@loc", "");
            cn.cmd.Parameters.AddWithValue("@des", "");
            cn.cmd.Parameters.AddWithValue("@st", "");
            cn.cmd.Parameters.AddWithValue("@ui", "");
            cn.cmd.Parameters.AddWithValue("@id", id);
            cn.cmd.Parameters.AddWithValue("@flag", 3);
            cn.cmd.ExecuteNonQuery();
        }
        public void update_potholedetect(et_potholedetect etn,int id)
        {
            cn.cmd = new SqlCommand("sp_potholedetect", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@img", "");
            cn.cmd.Parameters.AddWithValue("@loc", etn.location);
            cn.cmd.Parameters.AddWithValue("@des", etn.description);
            cn.cmd.Parameters.AddWithValue("@st", etn.status);
            cn.cmd.Parameters.AddWithValue("@ui", etn.uid);
            cn.cmd.Parameters.AddWithValue("@id",id);
            cn.cmd.Parameters.AddWithValue("@flag", 4);
            cn.cmd.ExecuteNonQuery();
        }
    }
}
