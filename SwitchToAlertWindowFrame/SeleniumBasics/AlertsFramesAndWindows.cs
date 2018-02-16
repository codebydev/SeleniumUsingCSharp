using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumBasics
{
    [TestClass]
    public class AlertsFramesAndWindows
    {
        [TestMethod]
        public void SwitchToAlert()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "file:///C:/Users/hanumanthargs/Downloads/HTML/test1.html";
            driver.FindElement(By.Id("alert")).Click();

            Thread.Sleep(2000);
            string text = driver.SwitchTo().Alert().Text;
            Console.WriteLine(text);
            driver.SwitchTo().Alert().Accept(); // To click on ok button

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void SwitchToConfirm()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "file:///C:/Users/hanumanthargs/Downloads/HTML/test1.html";
            driver.FindElement(By.Id("confirm")).Click();

            Thread.Sleep(2000);
            string text = driver.SwitchTo().Alert().Text;
            Console.WriteLine(text);
            driver.SwitchTo().Alert().Dismiss(); // To click on cancel button

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void SwitchToPrompt()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "file:///C:/Users/hanumanthargs/Downloads/HTML/test1.html";
            driver.FindElement(By.Id("prompt")).Click();

            Thread.Sleep(2000);
            driver.SwitchTo().Alert().SendKeys("I am learning selenium using c#");
            Thread.Sleep(2000);
           
            driver.SwitchTo().Alert().Accept(); // To click on cancel button

            Thread.Sleep(2000);
            driver.Quit();
        }

        [TestMethod]
        public void SwitchToFrame()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            driver.SwitchTo().Frame("login_page");
            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("1234");

            Thread.Sleep(4000);
            driver.Quit();
        }

        [TestMethod]
        public void SwitchToWindow()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://netbanking.hdfcbank.com/netbanking/";

            driver.SwitchTo().Frame("login_page");
            Console.WriteLine("Before click");
            Console.WriteLine("Number of windows "+driver.WindowHandles.Count);
            foreach (var item in driver.WindowHandles)
            {
                Console.WriteLine(item);
            }

            driver.FindElement(By.LinkText("Click here")).Click();

            Thread.Sleep(2000);
            Console.WriteLine("After click");
            Console.WriteLine("Number of windows " + driver.WindowHandles.Count);
            foreach (var item in driver.WindowHandles)
            {
                Console.WriteLine(item);
            }

            driver.SwitchTo().Window(driver.WindowHandles[1]);

            driver.FindElement(By.Name("fldLoginUserId")).SendKeys("1234");
            
            Thread.Sleep(4000);
            driver.Close();

            Console.WriteLine("After Closing the window");
            Console.WriteLine("Number of windows " + driver.WindowHandles.Count);
            foreach (var item in driver.WindowHandles)
            {
                Console.WriteLine(item);
            }
            driver.Quit();
        }
    }
}
