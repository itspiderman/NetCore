using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dalclasslib.com.dal.oracle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace Dalclasslib.com.dal
{
    [TestClass()]
    public class OracleSqlHelperTests
    {
        OracleSqlHelper sqlhelper = new OracleSqlHelper();
        [TestMethod()]
        public void querySQLDataReaderTest()
        {            
            string sqlstr = "select fundcode,fundname,fundurl,fundtypecode,crtDateTime from tfund where rownum<200 order by fundname";
            string userName = "";
            OracleDataReader dr = sqlhelper.querySQLDataReader(sqlstr);
            while (dr.Read())
            {
                userName = dr.GetString(0);
                Console.WriteLine("user name is " + userName);
                break;
            }
            dr.Close();
            Assert.AreEqual("000975", userName);
        }

        [TestMethod()]
        public void queryProcedureDataReaderTest()
        {
            //string queryFundSP = "queryFundSP";
            //DataSet dataSet = sqlhelper.queryProcedureDataSet(queryFundSP);
            //DataTable dataTable = dataSet.Tables[0];
            //string userName = "";
            //foreach(DataRow dRow in dataTable.Rows)
            //{
            //    userName = dRow[0].ToString();
            //    break;
            //}
            //Assert.AreEqual("kevin", userName);
            Assert.Fail();
        }

        [TestMethod()]
        public void queryProcedureDataReaderTest1()
        {
            Assert.Fail();
        }
    }
}