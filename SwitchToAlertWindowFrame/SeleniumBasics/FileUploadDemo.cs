using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumBasics
{
    [TestClass]
    public class FileUploadDemo
    {
        [TestMethod]
        public void FileUploadUsingAutoItTest()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Widgets";

            Thread.Sleep(2000);
            driver.FindElement(By.Id("image_file")).Click();
            Process.Start("uploadImage.exe");

            Thread.Sleep(4000);
            driver.Quit();
        }

        [TestMethod]
        public void FileUploadWithoutAutoItTest()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "http://uitestpractice.com/Students/Widgets";
            Thread.Sleep(2000);
            
            driver.FindElement(By.Id("image_file")).SendKeys("C:\\Users\\hanumanthargs\\Desktop\\VS 2017 installation.png");

            Thread.Sleep(4000);
            driver.Quit();
        }
    }
}
