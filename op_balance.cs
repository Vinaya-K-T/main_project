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
    public class op_balance
    {
        db_connection cn = new db_connection();
        public void insert_balance(et_balance etn)
        {
            cn.cmd = new SqlCommand("sp_balance", cn.connect());
            cn.cmd.CommandType=CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@am",etn.allocated_amount);
            cn.cmd.Parameters.AddWithValue("@sa",etn.spend_amount);
            cn.cmd.Parameters.AddWithValue("@dt", etn.date);
            cn.cmd.Parameters.AddWithValue("@ci",etn.cid);
            cn.cmd.Parameters.AddWithValue("@id", 1);
            cn.cmd.Parameters.AddWithValue("@flag", 1);
            cn.cmd.ExecuteNonQuery();
        }
        public void delete_balance(int id)
        {
            cn.cmd = new SqlCommand("sp_balance", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@am", "");
            cn.cmd.Parameters.AddWithValue("@sa", "");
            cn.cmd.Parameters.AddWithValue("@dt", "");
            cn.cmd.Parameters.AddWithValue("@ci", "");
            cn.cmd.Parameters.AddWithValue("@id", id);
            cn.cmd.Parameters.AddWithValue("@flag", 3);
            cn.cmd.ExecuteNonQuery();
        }
        public void update_balance(et_balance etn,int id)
        {
            cn.cmd = new SqlCommand("sp_balance", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@am", etn.allocated_amount);
            cn.cmd.Parameters.AddWithValue("@sa", etn.spend_amount);
            cn.cmd.Parameters.AddWithValue("@dt", etn.date);
            cn.cmd.Parameters.AddWithValue("@ci", etn.cid);
            cn.cmd.Parameters.AddWithValue("@id", id);
            cn.cmd.Parameters.AddWithValue("@flag", 4);
            cn.cmd.ExecuteNonQuery();
        }
    }
}
