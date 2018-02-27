using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumBasics
{
    [TestClass]
    public class Synchronization
    {
        [TestMethod]
        public void WaitUsingSleep()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Contact";

            driver.FindElement(By.PartialLinkText("This is")).Click();

            Thread.Sleep(15000);

            string text = driver.FindElement(By.ClassName("ContactUs")).Text;
            Assert.IsTrue(text.Contains("Python"));

            driver.Quit();
        }

        [TestMethod]
        public void WaitUsingImplicitWait()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
            driver.Url = "http://uitestpractice.com/Students/Contact";

            driver.FindElement(By.PartialLinkText("This is")).Click();

            // Thread.Sleep(15000);

            string text = driver.FindElement(By.ClassName("ContactUs")).Text;
            Assert.IsTrue(text.Contains("Python"));

            driver.Quit();
        }

        [TestMethod]
        public void WaitUsingExplicitWait()
        {
            IWebDriver driver = new FirefoxDriver();
            // driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
            driver.Url = "http://uitestpractice.com/Students/Contact";

            driver.FindElement(By.PartialLinkText("This is")).Click();

            // Thread.Sleep(15000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));
            wait.PollingInterval = TimeSpan.FromMilliseconds(50);

            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ContactUs")));

            string text = driver.FindElement(By.ClassName("ContactUs")).Text;
            Assert.IsTrue(text.Contains("Python"));

            driver.Quit();
        }

        [TestMethod]
        public void WaitUsingPageLoadTimeOut()
        {
            IWebDriver driver = new FirefoxDriver();
            // driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
            driver.Manage().Timeouts().SetPageLoadTimeout(TimeSpan.FromSeconds(150));
            driver.Url = "http://uitestpractice.com/Students/Contact";

            driver.FindElement(By.PartialLinkText("This is")).Click();

            // Thread.Sleep(15000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ContactUs")));

            string text = driver.FindElement(By.ClassName("ContactUs")).Text;
            Assert.IsTrue(text.Contains("Python"));

            driver.Quit();
        }

        [TestMethod]
        public void WaitUsingScriptTimeOut()
        {
            IWebDriver driver = new FirefoxDriver();
            // driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(15));
            driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(150));
            driver.Url = "http://uitestpractice.com/Students/Contact";

            driver.FindElement(By.PartialLinkText("This is")).Click();

            // Thread.Sleep(15000);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(15));

            wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName("ContactUs")));

            string text = driver.FindElement(By.ClassName("ContactUs")).Text;
            Assert.IsTrue(text.Contains("Python"));

            driver.Quit();
        }


    }
}
