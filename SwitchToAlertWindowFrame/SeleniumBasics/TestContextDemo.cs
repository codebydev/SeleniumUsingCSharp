using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasics
{
    [TestClass]
    public class TestContextDemo
    {
        private TestContext testContext;

        public TestContext TestContext
        {
            set { testContext = value; }
            get { return testContext; }
        }

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(TestContext.TestName);
        }
    }
}
