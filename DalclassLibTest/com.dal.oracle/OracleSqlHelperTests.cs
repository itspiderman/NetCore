using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dalclasslib.com.dal.oracle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Dalclasslib.com.dal.oracle
{
    [TestClass()]
    public class OracleSqlHelperTests
    {
        [TestMethod()]
        public void querySQLDataReaderTest()
        {
            OracleSqlHelper sqlhelper = new OracleSqlHelper();
            string sqlstr = "select * from tuser";
            string userName = "";
            SqlDataReader dr = sqlhelper.querySQLDataReader(sqlstr);
            while (dr.Read())
            {
                userName = dr.GetString(0);
                Console.WriteLine("user name is " + userName);
                break;
            }
            dr.Close();
            Assert.AreEqual("kevin", userName);
        }

        [TestMethod()]
        public void queryProcedureDataReaderTest()
        {
            
            Assert.Fail();
        }

        [TestMethod()]
        public void queryProcedureDataReaderTest1()
        {
            Assert.Fail();
        }
    }
}