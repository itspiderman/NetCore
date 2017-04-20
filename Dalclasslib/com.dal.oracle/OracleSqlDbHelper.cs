using System;
using System.Data;
using System.Data.SqlClient;

namespace Dalclasslib.com.dal.oracle
{
    public class OracleSqlHelper : iSqlHelper
    {
        //private string sqlConnectionString;
        private string getSqlConnectionString()
        {
            string sqlconnectionString= System.Configuration.ConfigurationManager.ConnectionStrings["DefaultDB"].ConnectionString.ToString();
            return sqlconnectionString;
        }
        public SqlDataReader querySQLDataReader(string strSQL)
        {
            SqlDataReader dr = null;
            //using (SqlConnection con = new SqlConnection(getSqlConnectionString()))
            //{
            SqlConnection con = new SqlConnection(getSqlConnectionString());
                con.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.Connection = con;

            dr = cmd.ExecuteReader();
            //con.Close();
            //con.Dispose();              
            //}
            //after leave this using code block, will call connection Dispose();
            return dr;
        }
        public SqlDataReader queryProcedureDataReader(string sStoreProName)
        {
            

            throw new NotImplementedException();
        }

        public SqlDataReader queryProcedureDataReader(string sStoreProName, string sPara1, string sPara2)
        {
            throw new NotImplementedException();
        }




    }
}
