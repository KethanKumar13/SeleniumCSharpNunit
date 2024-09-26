using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace NunitSelenium.Selenium
{
    internal class ActionsClass
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //Initialize web driver
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            IWebElement TodaysDeal = driver.FindElement(By.XPath("//a[contains(text(),\"Today's Deals\")]"));

            Actions actions = new Actions(driver);

            // Perform double click on the element
            actions.DoubleClick(TodaysDeal).Perform();
            Thread.Sleep(1000);

        }
        [TearDown]
        public void tearDownrowser()
        {
            driver.Close();
        }
    }
}
