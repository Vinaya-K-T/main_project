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
    public class op_login
    {
        db_connection cn=new db_connection();
        public void login_insert(et_login etn)
        {
            cn.cmd = new SqlCommand("sp_login", cn.connect());
            cn.cmd.CommandType=CommandType.StoredProcedure;
            cn.cmd.Parameters.AddWithValue("@un",etn.uname);
            cn.cmd.Parameters.AddWithValue("@pwd",etn.password);
            cn.cmd.Parameters.AddWithValue("@role",etn.role);
            cn.cmd.Parameters.AddWithValue("@flag", 1);
            cn.cmd.Parameters.AddWithValue("@id", 1);
            cn.cmd.ExecuteNonQuery();
           
        }
    }
}
