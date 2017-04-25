using System;
using System.Data;
using System.Data.SqlClient;
// oracle connection
//using System.Data.OracleClient;
using Oracle.ManagedDataAccess.Client;


namespace Dalclasslib.com.dal.oracle
{
    public class OracleSqlHelper //: iSqlHelper
    {
        //private string sqlConnectionString;
        private string getSqlConnectionString()
        {
            string sqlconnectionString= System.Configuration.ConfigurationManager.ConnectionStrings["DefaultDB"].ConnectionString.ToString();
            return sqlconnectionString;
        }
        private string getSqlConnectionString(string defaultDB)
        {
            string sqlConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["oracleDB"].ConnectionString.ToString();
            return sqlConnectionString;
        }
        
        public OracleDataReader querySQLDataReader(string strSQL)
        {
            OracleConnection con = new OracleConnection(getSqlConnectionString(""));
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = strSQL;
                cmd.Connection = con;

            OracleDataReader dr = cmd.ExecuteReader();            
            return dr;
        }
        public DataSet queryProcedureDataSet(string sStoreProName)
        {
            DataSet dataset = new DataSet();
            using (OracleConnection con = new OracleConnection(getSqlConnectionString("")))
            {
                con.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = sStoreProName; 
                OracleDataAdapter dataAdapter = new OracleDataAdapter(cmd);
                dataAdapter.Fill(dataset);                
            }
            return dataset;
        }

        public SqlDataReader queryProcedureDataReader(string sStoreProName, string sPara1, string sPara2)
        {
            throw new NotImplementedException();
        }
    }
}
