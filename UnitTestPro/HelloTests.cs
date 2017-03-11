using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp.Tests
{
    [TestClass()]
    public class HelloTests
    {
        Hello h = new Hello();

        [TestMethod()]
        public void sysHelloTest()
        {
            Assert.AreEqual("hello kevin!", h.sysHello());
        }
    }
}