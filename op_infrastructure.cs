using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_potholedete.DB_conn;
using DAL_potholedete.entities;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using System.Data;

namespace BLL_potholedete.operation
{
    public class op_infrastructure
    {
        db_connection cn = new db_connection();
        public void insert_infrastructure(et_infra etn)
        {
            cn.cmd = new SqlCommand("sp_infra", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@te", etn.i_type);
            cn.cmd.Parameters.AddWithValue("@lt", etn.location);
            cn.cmd.Parameters.AddWithValue("@cn", etn.condition);
            cn.cmd.Parameters.AddWithValue("@st", etn.speed_limit);
            cn.cmd.Parameters.AddWithValue("@pi",etn.pid);
            cn.cmd.Parameters.AddWithValue("@flag", 1);
            cn.cmd.Parameters.AddWithValue("@id", 1);
            cn.cmd.ExecuteNonQuery();
        }
        public void delete_infrastructure(int id)
        {
            cn.cmd = new SqlCommand("sp_infra", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@te", "");
            cn.cmd.Parameters.AddWithValue("@lt","");
            cn.cmd.Parameters.AddWithValue("@cn","");
            cn.cmd.Parameters.AddWithValue("@st","");
            cn.cmd.Parameters.AddWithValue("@pi", "");
            cn.cmd.Parameters.AddWithValue("@flag", 1);
            cn.cmd.Parameters.AddWithValue("@id", 1);
            cn.cmd.ExecuteNonQuery();
        }
        public void update_infrastructure(et_infra etn,int id)
        {
            cn.cmd = new SqlCommand("sp_infra", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@te", etn.i_type);
            cn.cmd.Parameters.AddWithValue("@lt", etn.location);
            cn.cmd.Parameters.AddWithValue("@cn", etn.condition);
            cn.cmd.Parameters.AddWithValue("@st", etn.speed_limit);
            cn.cmd.Parameters.AddWithValue("@pi", etn.pid);
            cn.cmd.Parameters.AddWithValue("@flag", 1);
            cn.cmd.Parameters.AddWithValue("@id", 1);
            cn.cmd.ExecuteNonQuery();
        }
    }
}
