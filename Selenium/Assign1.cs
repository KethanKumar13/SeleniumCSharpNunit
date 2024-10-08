﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitSelenium.Selenium
{
    internal class Assign1
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //Initialize web driver
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            //Launch chrome browser
            driver.Navigate().GoToUrl("https://demowebshop.tricentis.com/register");
        }
        [Test]
        public void testcase1()
        {
            Thread.Sleep(3000);

            IWebElement Gender = driver.FindElement(By.XPath("//input[@id='gender-male']"));
            Gender.Click();

            Thread.Sleep(2000);

            IWebElement FirstName = driver.FindElement(By.Name("FirstName"));
            FirstName.SendKeys("Kethan");

            Thread.Sleep(2000);

            IWebElement LastName = driver.FindElement(By.Name("LastName"));
            LastName.SendKeys("Kumar");

            Thread.Sleep(2000);

            IWebElement Email = driver.FindElement(By.Name("Email"));
            Email.SendKeys("kethankumar136@gmail.com");

            Thread.Sleep(2000);

            IWebElement Password = driver.FindElement(By.Name("Password"));
            Password.SendKeys("kethan@123");

            Thread.Sleep(2000);

            IWebElement ConfirmPassword = driver.FindElement(By.Name("ConfirmPassword"));
            ConfirmPassword.SendKeys("kethan@123");

            Thread.Sleep(2000);

            IWebElement Register = driver.FindElement(By.XPath("//input[@id='register-button']"));
            Register.Click();

        }
        [TearDown]
        public void tearDownrowser()
        {
            driver.Close();
        }
    }
}
