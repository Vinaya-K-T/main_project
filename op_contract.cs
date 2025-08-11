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
    public class op_contract
    {
        db_connection cn = new db_connection();
        public void insert_contract(et_contract etn)
        {
            cn.cmd = new SqlCommand("sp_contract", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@cm", etn.company_name);
            cn.cmd.Parameters.AddWithValue("@cd", etn.company_address);
            cn.cmd.Parameters.AddWithValue("@cr", etn.contact_person);
            cn.cmd.Parameters.AddWithValue("@pn", etn.phone);
            cn.cmd.Parameters.AddWithValue("@dt", etn.district);
            cn.cmd.Parameters.AddWithValue("@an", etn.annual_turnover);
            cn.cmd.Parameters.AddWithValue("@flag", 1);
            cn.cmd.Parameters.AddWithValue("@id", 1);
            cn.cmd.ExecuteNonQuery();
        }
        public void delete_contract(int id)
        {
            cn.cmd = new SqlCommand("sp_contract", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@cm","");
            cn.cmd.Parameters.AddWithValue("@cd", "");
            cn.cmd.Parameters.AddWithValue("@cr", "");
            cn.cmd.Parameters.AddWithValue("@pn", "");
            cn.cmd.Parameters.AddWithValue("@dt", "");
            cn.cmd.Parameters.AddWithValue("@an", "");
            cn.cmd.Parameters.AddWithValue("@an", "");
            cn.cmd.Parameters.AddWithValue("@flag", 3);
            cn.cmd.Parameters.AddWithValue("@id", id);
            cn.cmd.ExecuteNonQuery();
        }
        public void update_contract(et_contract etn,int id)
        {
            cn.cmd = new SqlCommand("sp_contract", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@cm", etn.company_name);
            cn.cmd.Parameters.AddWithValue("@cd", etn.company_address);
            cn.cmd.Parameters.AddWithValue("@cr", etn.contact_person);
            cn.cmd.Parameters.AddWithValue("@pn", etn.phone);
            cn.cmd.Parameters.AddWithValue("@dt", etn.district);
            cn.cmd.Parameters.AddWithValue("@an", etn.annual_turnover);
            cn.cmd.Parameters.AddWithValue("@flag", 4);
            cn.cmd.Parameters.AddWithValue("@id", id);
            cn.cmd.ExecuteNonQuery();
        }
    }
}
