using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;

namespace PABuchungssystemSQL
{
    public class DataAccess
    {
        public DataTable GetAllFromKunden()
        {
            using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
            {
                sqlConn.Open();
                string sqlCmd = "select * from kunden";
                SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd, sqlConn);
                DataTable dt = new DataTable();
                sqlDa.Fill(dt);
                return dt;
            }
        }

        public void UpdateKunde()
        {
                using (SqlConnection sqlConn = new SqlConnection(Helper.CnnVal("managementDB")))
                {
                    sqlConn.Open();
                    string sqlCmd = "update kunde set";
                    SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd, sqlConn);
                    DataTable dt = new DataTable();
                    sqlDa.Fill(dt);
                }
        }
    }
}