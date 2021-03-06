﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Data.SqlClient;

namespace Dalclasslib.com.dal.mssql.Tests
{
    [TestClass()]
    public class MsSqlHelperTests
    {
        MsSqlHelper msSQLHelper = new MsSqlHelper();
        [TestMethod()]
        public void getConnectionInstanceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void openConnectionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void closeConnectionTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void querySQLDataReaderTest()
        {
            SqlDataReader dataReader = msSQLHelper.querySQLDataReader("select * from tuser");
            string userName = "";
            while (dataReader.Read())
            {
                Console.WriteLine(dataReader.GetString(0));
                userName = dataReader.GetString(0);
            }
            dataReader.Close();
            Assert.AreEqual("kevin", userName);
        }

        [TestMethod()]
        public void queryProcedureDataSetTest()
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