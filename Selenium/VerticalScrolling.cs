using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitSelenium.Selenium
{
    internal class VerticalScrolling
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //Initialize web driver
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.selenium.dev/");
            driver.Manage().Window.Maximize();
        }
        [Test]
        public void testcase1()
        {
            //scroll down

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            //0-x cordinate

            js.ExecuteScript("window.scrollBy(0,800)", "");

            Thread.Sleep(3000);
            //scroll up

            

            //0-x cordinate

            js.ExecuteScript("window.scrollBy(0,-300)", "");

            Thread.Sleep(3000);

            //bottom of the page

            js.ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");

            Thread.Sleep(3000);



        }
        [TearDown]
        public void tearDownrowser()
        {
            driver.Close();
        }
    }
}
