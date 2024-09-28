﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Chrome;

namespace NunitSelenium.Selenium
{
    internal class Table2
    {
        IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //Initialize web driver
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void testcase1()
        {

            // xpath of the html web table

            IWebElement table = driver.FindElement(By.XPath("//table[@id = 'product']"));

            // fetch the all rows of the table

            List<IWebElement> trrow = new List<IWebElement>(table.FindElements(By.XPath("//table[@id = 'product']/tbody/tr")));

            int rowcount = trrow.Count();

            Console.WriteLine(rowcount);

            // fecth the no of columns

            List<IWebElement> tdcol = new List<IWebElement>(table.FindElements(By.XPath("//table[@id = 'product']/tbody/tr[7]/td")));

            int colcount = tdcol.Count();

            Console.WriteLine(colcount);

            // cell data

            IWebElement celldata = driver.FindElement(By.XPath("//table[@id = 'product']/tbody/tr[8]/td[2]"));

            string text = celldata.Text;

            Console.WriteLine(text);


        }

        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }

    }
}