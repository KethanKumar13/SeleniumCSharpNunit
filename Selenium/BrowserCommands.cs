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
    internal class BrowserCommands
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //Initialize web driver
            driver = new ChromeDriver();
        }
        [Test]
        public void testcase1()
        {
            
            //Launch chrome browser
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            string title = driver.Title;
            Console.WriteLine(title);

            string currentrurl = driver.Url;
            Console.WriteLine(currentrurl);

            //fetch the page source of the html page
            string pagesource = driver.PageSource;
            Console.WriteLine(pagesource);

            
        }
        [TearDown]
        public void tearDownrowser()
        {
            //will close the current browser section
            driver.Close();

            //will close all the browser session of the browser
            //driver.Quit();
        }
    
}
}
