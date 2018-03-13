using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumBasics
{
    [TestClass]
    public class DropDownCheckboxAndRadiobutton
    {
        [TestMethod]
        public void RadioButtonTest()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";
            Thread.Sleep(4000);

            driver.FindElement(By.Id("u_0_c")).Click();
            bool selected=driver.FindElement(By.Id("u_0_c")).Selected;
            Console.WriteLine("Male radio button selected : "+selected);

            selected = driver.FindElement(By.Id("u_0_b")).Selected;
            Console.WriteLine("Female radio button selected : " + selected);

            Thread.Sleep(4000);
            driver.Quit();
        }

        [TestMethod]
        public void CheckBoxTest()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Form";
            Thread.Sleep(4000);

            driver.FindElement(By.XPath("//input[@value='dance']")).Click();
            bool selected = driver.FindElement(By.XPath("//input[@value='dance']")).Selected;
            Console.WriteLine("Dancing check box selected : " + selected);

            selected = driver.FindElement(By.XPath("//input[@value='read']")).Selected;
            Console.WriteLine("Reading check box selected : " + selected);

            Thread.Sleep(4000);
            driver.Quit();
        }

        [TestMethod]
        public void DropDownValueSelectTest()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";
            Thread.Sleep(4000);

            SelectElement dropdown = new SelectElement(driver.FindElement(By.Id("day")));
            dropdown.SelectByText("4");

            dropdown = new SelectElement(driver.FindElement(By.Id("month")));
            dropdown.SelectByValue("12");

            Thread.Sleep(4000);
            driver.Quit();
        }

        [TestMethod]
        public void CaptureScreenShot()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";
            Thread.Sleep(4000);

            ((ITakesScreenshot)driver).GetScreenshot().SaveAsFile("test.jpeg", ImageFormat.Jpeg);

            driver.Quit();
        }

        [TestMethod]
        public void ExecuteJavaScript()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://www.facebook.com/";
            Thread.Sleep(4000);

            ((IJavaScriptExecutor)driver).ExecuteScript("alert('Hello everyone');");

            Thread.Sleep(4000);
            driver.Quit();
        }

    }
    }
