using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
//user namespace
using Dalclasslib.com.dal.oracle;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace Dalclasslib.com.dal
{
    public class TfundReadDao:iDbReadDao
    {
       // iSqlHelper sh;
        public TfundReadDao()
        {
           // sh = new OracleSqlHelper();
        }

        public int execProcedure(string sStoreProName)
        {
            //throw new NotImplementedException();
            //1.6.0之前写法
           //Database defaulDB = DatabaseFactory.CreateDatabase("DefaultDB");
            //String conString = defaulDB.ConnectionString;
                       
            DatabaseProviderFactory factory = new DatabaseProviderFactory();
            String conStr = ConfigurationManager.ConnectionStrings["DefaultDB"].ConnectionString;

            //String conStr = "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=False;Initial Catalog=posdb;User ID=sa;Password=sa;Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            Database defaulDB = factory.Create(conStr);
            
            
            String strSQL = "select * from tuser";
            DbCommand cmd = defaulDB.GetSqlStringCommand(strSQL);

            DbDataReader dr = (DbDataReader) defaulDB.ExecuteReader(cmd);

            while (dr.HasRows)
            {
                Console.WriteLine(dr.GetString(0));
            }

            return 1;
        }

        public int execProcedure(string sStoreProName, string sPara1)
        {
            return execProcedure("");
        }

        public int execProcedure(string sStoreProName, string sPara1, string sPara2)
        {
            throw new NotImplementedException();
        }

        public int execProcedure(string sStoreProName, string sPara1, string sPara2, string sPara3)
        {
            throw new NotImplementedException();
        }

        public int execProcedure(string sStoreProName, string sPara1, string sPara2, string sPara3, string sPara4)
        {
            throw new NotImplementedException();
        }

        public int execProcedure(string sStoreProName, string sPara1, string sPara2, string sPara3, string sPara4, string sPara5)
        {
            throw new NotImplementedException();
        }

        public int selectCount(string sStoreProName)
        {
            throw new NotImplementedException();
        }

        public int selectCount(String sPara1,String sPara2)
        {
            return execProcedure("", "");
        }

        public int selectCount(string sStoreProName, string sPara1, string sPara2)
        {
            throw new NotImplementedException();
        }

        public int selectCount(string sStoreProName, string sPara1, string sPara2, string sPara3)
        {
            return execProcedure("", "");
        }

        public int selectCount(string sStoreProName, string sPara1, string sPara2, string sPara3, string sPara4)
        {
            throw new NotImplementedException();
        }

    }
}
