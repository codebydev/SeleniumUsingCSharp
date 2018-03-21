using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;

namespace SeleniumGrid
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // IWebDriver driver = new FirefoxDriver();

            DesiredCapabilities capabilities = DesiredCapabilities.Chrome();
            IWebDriver driver = new RemoteWebDriver(new Uri("http://10.98.232.220:4444/wd/hub"),capabilities);

            driver.Url = "http://google.com";

            driver.Quit();
        }
    }
}
