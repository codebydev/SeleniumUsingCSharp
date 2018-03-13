using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumBasics
{
    [TestClass]
    public  class DataDrivenTestingDemo
    {
        private TestContext testContext;

        public TestContext TestContext
        {
            set { testContext = value; }
            get { return testContext; }
        }

        private IWebDriver driver;

        [TestInitialize]
        public void TestInitialize()
        {
            driver = new FirefoxDriver();
            driver.Url = "http://facebook.com";
        }
        
        [TestCleanup]
        public void TestCleanUp()
        {
            driver.Quit();
        }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.CSV",
            "|DataDirectory|\\data.csv",
            "data#csv",
            DataAccessMethod.Sequential)]
        [DeploymentItem("data.csv")]
        [TestMethod]
        public void DataDrivenUsingCSV()
        {
            //driver.FindElement(By.Id("email")).SendKeys("demo@demo.com");
            //driver.FindElement(By.Id("pass")).SendKeys("abcd1234");
            driver.FindElement(By.Id("email")).SendKeys(TestContext.DataRow[0].ToString());
            driver.FindElement(By.Id("pass")).SendKeys(TestContext.DataRow[1].ToString());
        }

        [DataSource(
            "Microsoft.VisualStudio.TestTools.DataSource.XML",
            "|DataDirectory|\\data.xml",
            "user",
            DataAccessMethod.Sequential)]
        [DeploymentItem("data.xml")]
        [TestMethod]
        public void DataDrivenUsingXML()
        {
            driver.FindElement(By.Id("email")).SendKeys(TestContext.DataRow["username"].ToString());
            driver.FindElement(By.Id("pass")).SendKeys(TestContext.DataRow["password"].ToString());
        }

        [DataSource(
            "System.Data.SqlClient",
            "Server=.\\Sqlexpress; Database=TestDb;User Id=sa; Password=Harman01*;",
            "user",
            DataAccessMethod.Sequential)]        
        [TestMethod]
        public void DataDrivenUsingSQL()
        {
            driver.FindElement(By.Id("email")).SendKeys(TestContext.DataRow["username"].ToString());
            driver.FindElement(By.Id("pass")).SendKeys(TestContext.DataRow["password"].ToString());
        }

        [DataSource(
            "System.Data.Odbc",
            "Dsn=Excel Files; dbq=|Data Directory|\\Data.Xlsx; Data Source=Data.Xlsx;Persist Security Info=False; ExtendedProperties='Excel 12.0; HDR=Yes'",
            "Data$",
            DataAccessMethod.Sequential)]
        [TestMethod]
        public void DataDrivenUsingExcel()
        {
            driver.FindElement(By.Id("email")).SendKeys(TestContext.DataRow["username"].ToString());
            driver.FindElement(By.Id("pass")).SendKeys(TestContext.DataRow["password"].ToString());
        }
    }
}
