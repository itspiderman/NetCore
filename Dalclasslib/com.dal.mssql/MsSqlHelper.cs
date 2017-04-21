using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Dalclasslib.com.dal.mssql
{
    public sealed class MsSqlHelper : iSqlHelper
    {
        private static SqlConnection con = null;
        public static int connectionCount=0;
        private static string sqlConnectionString = "Data Source = (localdb)\\MSSQLLocalDB;Integrated Security = False; Initial Catalog = posdb; User ID = sa; Password=sa;"
                                                   +"Connect Timeout = 15; Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private static readonly object lockHelper = new object();

        private string getSqlConnectionString()
        {
            return sqlConnectionString;
        }

        public string SqlConnectionString
        {
            get
            {
               return sqlConnectionString;
            }
        }

        public static SqlConnection getConnectionInstance()
        {
            if (con == null)
            {
                lock (lockHelper)
                {
                    if (con == null)
                    {                        
                        con = new SqlConnection();
                        con.ConnectionString = sqlConnectionString;
                        openConnection();
                        connectionCount++;
                    }
                }
            }
            else
            {
                openConnection();
            }
            return con;
        }
        public static void openConnection()
        {
            if (con.State != System.Data.ConnectionState.Open)
            {
                con.Open();
            }
        }
        public static void closeConnection()
        {
            if (con.State != System.Data.ConnectionState.Closed)
            {
                con.Close();
            }
        }
        //1. Return DataReader
        public SqlDataReader querySQLDataReader(string strSQL)
        {
            //SqlCommand cmd = new SqlCommand();            
            //cmd.Connection = getConnectionInstance();
            //Console.WriteLine("connection count is " + connectionCount);
            //cmd.CommandText = strSQL;
            ////cmd.Parameters
            //SqlDataReader dataReader = cmd.ExecuteReader();
            //return dataReader;
            //
            SqlDataReader dr = null;
            SqlConnection con = new SqlConnection(getSqlConnectionString());
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = strSQL;
            cmd.Connection = con;

            dr = cmd.ExecuteReader();
            
            return dr;
        }

        public DataSet queryProcedureDataSet(string sStoreProName)
        {
            throw new NotImplementedException();
        }
        public SqlDataReader queryProcedureDataReader(string sStoreProName, string sPara1, string sPara2)
        {
            throw new NotImplementedException();
        }
        //2. Return DataTable


    }
}
