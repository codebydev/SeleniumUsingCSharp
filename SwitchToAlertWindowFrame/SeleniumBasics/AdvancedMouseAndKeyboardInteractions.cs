using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SeleniumBasics
{
    [TestClass]
    public class AdvancedMouseAndKeyboardInteractions
    {
        [TestMethod]
        public void DoublClick()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "file:///C:/Users/hanumanthargs/Downloads/HTML/DoubleClick.html";

            Thread.Sleep(4000);

            Actions actions = new Actions(driver);

            actions
                .DoubleClick(driver.FindElement(By.Name("dblClick")))
                .Build()
                .Perform();

            Thread.Sleep(4000);
            

            driver.Quit();          

        }

        [TestMethod]
        public void DragAndDrop()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "file:///C:/Users/hanumanthargs/Downloads/HTML/DragAndDrop.html";

            Thread.Sleep(4000);

            Actions actions = new Actions(driver);

            actions
                .DragAndDrop(driver.FindElement(By.Id("draggable")),driver.FindElement(By.Id("droppable")))
                .Build()
                .Perform();

            Thread.Sleep(4000);

            driver.Quit();
        }

        [TestMethod]
        public void KeyDownAndKeyUp()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "file:///C:/Users/hanumanthargs/Downloads/HTML/Selectable.html";

            Thread.Sleep(4000);

            Actions actions = new Actions(driver);

            actions
                .KeyDown(Keys.LeftControl)
                .Click(driver.FindElement(By.Name("one")))
                .Click(driver.FindElement(By.Name("six")))
                .Click(driver.FindElement(By.Name("three")))
                .Click(driver.FindElement(By.Name("ten")))
                .Click(driver.FindElement(By.Name("five")))
                .KeyUp(Keys.LeftControl)
                .Build()
                .Perform();

            Thread.Sleep(4000);

            driver.Quit();
        }

        [TestMethod]
        public void RightClickOrContextClick()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "file:///C:/Users/hanumanthargs/Downloads/HTML/Selectable.html";

            Thread.Sleep(4000);

            Actions actions = new Actions(driver);

            actions
                .MoveToElement(driver.FindElement(By.Name("four")))
                .ContextClick()
                .Build()
                .Perform();

            Thread.Sleep(4000);

            driver.Quit();
        }

        [TestMethod]
        public void ClickHoldAndRelease()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "file:///C:/Users/hanumanthargs/Downloads/HTML/Selectable.html";

            Thread.Sleep(4000);

            Actions actions = new Actions(driver);

            actions
                .ClickAndHold(driver.FindElement(By.Name("one")))
                .MoveToElement(driver.FindElement(By.Name("eleven")))
                .Release()                
                .Build()
                .Perform();

            Thread.Sleep(4000);

            driver.Quit();
        }

        [TestMethod]
        public void MoveByOffset()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "file:///C:/Users/hanumanthargs/Downloads/HTML/Selectable.html";

            Thread.Sleep(4000);

            Actions actions = new Actions(driver);

            Point p = driver.FindElement(By.Name("two")).Location;

            actions
                .MoveToElement(driver.FindElement(By.Name("eleven")))
                .Click()
                .MoveByOffset(20,20)
                .ContextClick()                
                .Build()
                .Perform();

            Thread.Sleep(4000);

            driver.Quit();
        }
    }
}
