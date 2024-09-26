using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace NunitSelenium.Selenium
{
    internal class DropDown
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //Initialize web driver
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
        }
        [Test]
        public void testcase1()
        {
            IWebElement DropDown = driver.FindElement(By.Id("dropdown-class-example"));
            Assert.IsNotNull(DropDown);
            var select = new SelectElement(DropDown);

            //selct by visible text
            select.SelectByText("Option2");


            //selct by visible index
            
            select.SelectByIndex(1);
            Thread.Sleep(3000);

            
            select.SelectByValue("option3");
            



            //Launch chrome browser
            //driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            


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
