using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApp.xpgroup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.xpgroup.Tests
{
    [TestClass()]
    public class XpgroupTests
    {
        [TestMethod()]
        public void chekTargetStringTest1()
        {
            Xpgroup xpgroup = new Xpgroup();
            string key1 = "n";
            string value1 = "Bastian";
            Assert.AreEqual(value1, xpgroup.confirmEnding(value1, key1));
        }
        [TestMethod()]
        public void chekTargetStringTest2()
        {
            Xpgroup xpgroup = new Xpgroup();
            string key1 = "n";
            string value1 = "Connor";
            Assert.AreEqual("", xpgroup.confirmEnding(value1, key1));
        }
    }
}