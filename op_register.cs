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
    public class op_register
    {
        db_connection cn = new db_connection();
        public void registration_insert(et_register etn)
        {
            cn.cmd = new SqlCommand("sp_register", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@fn", etn.name);
            cn.cmd.Parameters.AddWithValue("@pno",etn.phone);
            cn.cmd.Parameters.AddWithValue("@em", etn.email);
            cn.cmd.Parameters.AddWithValue("@pswd", etn.password);
            cn.cmd.Parameters.AddWithValue("@un", etn.uname);
            cn.cmd.Parameters.AddWithValue("@id", 1);
            cn.cmd.Parameters.AddWithValue("@flag", 1);
            cn.cmd.ExecuteNonQuery();
        }
        public void update_register(et_register etn,int id)
        {
            cn.cmd = new SqlCommand("sp_register", cn.connect());
            cn.cmd.CommandType = CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@fn", etn.name);
            cn.cmd.Parameters.AddWithValue("@pno", etn.phone);
            cn.cmd.Parameters.AddWithValue("@em", etn.email);
            cn.cmd.Parameters.AddWithValue("@pswd", etn.password);
            cn.cmd.Parameters.AddWithValue("@un", etn.uname);
            cn.cmd.Parameters.AddWithValue("@id", id);
            cn.cmd.Parameters.AddWithValue("@flag",4);
            cn.cmd.ExecuteNonQuery();
        }
    }
}
