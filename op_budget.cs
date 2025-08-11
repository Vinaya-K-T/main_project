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
    public class op_budget
    {
        db_connection cn=new db_connection();
        public void insert_budget(et_budget etn)
        {
            cn.cmd = new SqlCommand("sp_budget", cn.connect());
            cn.cmd.CommandType= CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@pp",etn.project_phase);
            cn.cmd.Parameters.AddWithValue("@cn",etn.complaint_name);
            cn.cmd.Parameters.AddWithValue("@am",etn.allocated_amount);
            cn.cmd.Parameters.AddWithValue("@et",etn.expense_type);
            cn.cmd.Parameters.AddWithValue("@ed",etn.entry_date);
            cn.cmd.Parameters.AddWithValue("@st", etn.status);
            cn.cmd.Parameters.AddWithValue("@rn", etn.reason);
            cn.cmd.Parameters.AddWithValue("@ci",etn.cid);
            cn.cmd.Parameters.AddWithValue("@id", 1);
            cn.cmd.Parameters.AddWithValue("@flag", 1);
            cn.cmd.ExecuteNonQuery();
        }
        public void delete_budget(int id)
        {
            cn.cmd = new SqlCommand("sp_budget", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@pp","");
            cn.cmd.Parameters.AddWithValue("@cn", "");
            cn.cmd.Parameters.AddWithValue("@am", "");
            cn.cmd.Parameters.AddWithValue("@et", "");
            cn.cmd.Parameters.AddWithValue("@ed", "");
            cn.cmd.Parameters.AddWithValue("@st","");
            cn.cmd.Parameters.AddWithValue("@rn", "");
            cn.cmd.Parameters.AddWithValue("@ci", "");
            cn.cmd.Parameters.AddWithValue("@flag", 3);
            cn.cmd.Parameters.AddWithValue("@id", id);
            cn.cmd.ExecuteNonQuery();
        }
        public void update_budget(et_budget etn,int id)
        {
            cn.cmd = new SqlCommand("sp_budget", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@pp", etn.project_phase);
            cn.cmd.Parameters.AddWithValue("@cn", etn.complaint_name);
            cn.cmd.Parameters.AddWithValue("@am", etn.allocated_amount);
            cn.cmd.Parameters.AddWithValue("@et", etn.expense_type);
            cn.cmd.Parameters.AddWithValue("@ed", etn.entry_date);
            cn.cmd.Parameters.AddWithValue("@st", etn.status);
            cn.cmd.Parameters.AddWithValue("@rn", etn.reason);
            cn.cmd.Parameters.AddWithValue("@ci", etn.cid);
            cn.cmd.Parameters.AddWithValue("@flag", 4);
            cn.cmd.Parameters.AddWithValue("@id",id);
            cn.cmd.ExecuteNonQuery();
        }
    }
}
