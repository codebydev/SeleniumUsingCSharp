using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasics
{
    [TestClass]
    public class AvoidCodeRedundency
    {
        [AssemblyInitialize]
        public static void AssembllyInitialize(TestContext tc)
        {
            Console.WriteLine("AssemblyInitialize");
        }

        [AssemblyCleanup]
        public static void AssembllyCleanup()
        {
            Console.WriteLine("AssemblyCleanup");
        }

        [ClassInitialize]
        public static void ClassInitialize(TestContext tc)
        {
            Console.WriteLine("ClassInitialize");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Console.WriteLine("ClassCleanup");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Console.WriteLine("Testinitialize");
        }

        [TestCleanup]
        public void TestCleanUp()
        {
            Console.WriteLine("TestCleanup");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("Within test method 1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("Within test method 2");
        }
    }
}
