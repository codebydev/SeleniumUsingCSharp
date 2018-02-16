using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace SeleniumBasics
{
    [TestClass]
    public class SelBasics
    {
        [TestMethod]
        public void LaunchBrowser()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://cricinfo.com";
            driver.Quit();
        }

        [TestMethod]
        public void ReadTitle()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "file:///C:/Users/hanumanthargs/Desktop/Demo.html";
            Console.WriteLine(driver.Title);
            driver.Quit();
        }

        [TestMethod]
        public void LocateByName()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.theonlinecalculator.com/";
            driver.FindElement(By.Name("four")).Click();
            driver.FindElement(By.Name("add")).Click();
            driver.FindElement(By.Name("two")).Click();
            driver.FindElement(By.Name("calculate")).Click();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void LocateById()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";
            driver.FindElement(By.Id("u_0_l")).SendKeys("Rahul");
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void LocateByClassName()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "file:///C:/Users/hanumanthargs/Desktop/Demo.html";
            string text=driver.FindElement(By.ClassName("two")).Text;
            Console.WriteLine(text);
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void LocateByTagName()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "file:///C:/Users/hanumanthargs/Desktop/Demo.html";
            string text = driver.FindElement(By.TagName("p")).Text;
            Console.WriteLine(text);
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void LocateByLinkText()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "file:///C:/Users/hanumanthargs/Desktop/Demo.html";
            driver.FindElement(By.LinkText("Go to google")).Click();
            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void LocateByPartialLinkText()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "file:///C:/Users/hanumanthargs/Desktop/Demo.html";
            driver.FindElement(By.PartialLinkText("Go to")).Click();
            Thread.Sleep(2000);
            driver.Quit();
        }


    }
}
