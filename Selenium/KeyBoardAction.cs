using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;

namespace NunitSelenium.Selenium
{
    internal class KeyBoardAction
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //Initialize web driver
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void KeysDown()
        {
            new Actions(driver)
                .KeyDown(Keys.Shift)
                .SendKeys("a")
                .Perform();
            Thread.Sleep(2000);

        }

        [Test]
        public void KeysUp()
        {

            new Actions(driver)
                .KeyUp(Keys.Shift)
                .SendKeys("A")
                .Perform();
            Thread.Sleep(2000);

        }
        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }


    }
}
