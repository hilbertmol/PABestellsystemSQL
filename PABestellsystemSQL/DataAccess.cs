using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace PABestellsystemSQL
{
    public static class DataAccess
    {
        public static DataTable GetAllManagementDB(string tableName)
        {
            using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
            {
                sqlConn.Open();
                string sqlCmd = "select * from " + tableName;
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd, sqlConn);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetAllLoginDB(string tableName)
        {
            using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("LoginDB")))
            {
                sqlConn.Open();
                string sqlCmd = "select * from " + tableName;
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd, sqlConn);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                return dt;
            }
        }
    }
}