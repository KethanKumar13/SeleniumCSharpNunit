﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;

namespace NunitSelenium.Selenium
{
    internal class Assign2
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //Initialize web driver
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void testcase1()
        {
            Thread.Sleep(2000);

            IWebElement Username = driver.FindElement(By.Name("user-name"));
            Username.SendKeys("standard_user");

            Thread.Sleep(2000);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys("secret_sauce");

            IWebElement LoginButton = driver.FindElement(By.XPath("//input[@id='login-button']"));
            LoginButton.Click();



        }
        [TearDown]
        public void tearDownrowser()
        {
            driver.Close();
        }
    }
}
