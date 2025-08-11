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
    public class op_feedback
    {
        db_connection cn = new db_connection();
        public void feedback_insert(et_feedback etn)
        {
            cn.cmd = new SqlCommand("sp_feedback", cn.connect());
            cn.cmd.CommandType= CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@em", etn.email);
            cn.cmd.Parameters.AddWithValue("@msg",etn.message);
            cn.cmd.Parameters.AddWithValue("@sub", etn.submission_date);
            cn.cmd.Parameters.AddWithValue("@ui",etn.uid);
            cn.cmd.Parameters.AddWithValue("@id", 2);
            cn.cmd.Parameters.AddWithValue("@flag", 1);
            cn.cmd.ExecuteNonQuery();
        }
        public void delete_feedback(int id)
        {
            cn.cmd = new SqlCommand("sp_feedback", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@em", "");
            cn.cmd.Parameters.AddWithValue("@msg", "");
            cn.cmd.Parameters.AddWithValue("@sub", "");
            cn.cmd.Parameters.AddWithValue("@ui", "");
            cn.cmd.Parameters.AddWithValue("@id", id);
            cn.cmd.Parameters.AddWithValue("@flag", 3);
            cn.cmd.ExecuteNonQuery();
        }
        public void update_feedback(et_feedback etn, int id)
        {
            cn.cmd = new SqlCommand("sp_feedback", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@em", etn.email);
            cn.cmd.Parameters.AddWithValue("@msg",etn.message);
            cn.cmd.Parameters.AddWithValue("@sub",etn.submission_date);
            cn.cmd.Parameters.AddWithValue("@ui", etn.uid);
            cn.cmd.Parameters.AddWithValue("@id", id);
            cn.cmd.Parameters.AddWithValue("@flag", 4);
            cn.cmd.ExecuteNonQuery();
        }
    }
}
