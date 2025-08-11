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
    public class op_userr
    {
        db_connection cn=new db_connection();
        public void insert_user(et_userr etn)
        {
            cn.cmd = new SqlCommand("sp_userr", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@nm", etn.uname);
            cn.cmd.Parameters.AddWithValue("@em", etn.email);
            cn.cmd.Parameters.AddWithValue("@ph", etn.phone);
            cn.cmd.Parameters.AddWithValue("@id", 1);
            cn.cmd.Parameters.AddWithValue("@flag", 1);
            cn.cmd.ExecuteNonQuery();
        }
    }
}
