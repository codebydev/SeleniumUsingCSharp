using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumBasics
{
    [TestClass]
    public class CrossBrowserTesting
    {
        [TestMethod]
        public void CrossBrowserTestOnFirefoxBrowser()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://facebook.com";
            Thread.Sleep(4000);
            driver.Quit();
        }

        [TestMethod]
        public void CrossBrowserTestOnChromeBrowser()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "http://facebook.com";
            Thread.Sleep(4000);
            driver.Quit();
        }

        [TestMethod]
        public void CrossBrowserTestOnIEBrowser()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "http://facebook.com";
            Thread.Sleep(4000);
            driver.Quit();
        }

        [TestMethod]
        public void CrossBrowserTestOnPhantomJS()
        {
            IWebDriver driver = new PhantomJSDriver();
            driver.Url = "http://facebook.com";
            Thread.Sleep(4000);
            driver.Quit();
        }

    }
}
