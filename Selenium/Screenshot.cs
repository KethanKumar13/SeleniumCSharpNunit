using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.Extensions;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitSelenium.Selenium
{
    internal class Screenshot
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //Initialize web driver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //Launch browser
            driver.Navigate().GoToUrl("https://www.selenium.dev/");

        }
        [Test]
        public void testcase1()
        {
            OpenQA.Selenium.Screenshot ss = ((ITakesScreenshot)driver).GetScreenshot();

            ss.SaveAsFile("C:\\Users\\kekum\\Downloads\\er.jpg");
        }
        [TearDown]
        public void tearDownbrowser()
        {
            driver.Close();
        }
    }
}
