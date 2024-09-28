using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using WebDriverManager.DriverConfigs.Impl;

namespace NunitSelenium.Selenium
{
    internal class Assignment3
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
       
            IWebElement submitButton = driver.FindElement(By.Id("login-button"));
            submitButton.Click();

            Thread.Sleep(2000);

            IWebElement addToCartButton = driver.FindElement(By.Id("add-to-cart-sauce-labs-backpack"));
            addToCartButton.Click();
            Thread.Sleep(2000);

            IWebElement cartButton = driver.FindElement(By.ClassName("shopping_cart_link"));
            cartButton.Click();
            Thread.Sleep(2000);

            IWebElement checkoutButton = driver.FindElement(By.Id("checkout"));
            checkoutButton.Click();
            Thread.Sleep(2000);

            IWebElement firstNameInput = driver.FindElement(By.Id("first-name"));
            firstNameInput.SendKeys("abc");
            Thread.Sleep(2000);

            IWebElement lastNameInput = driver.FindElement(By.Id("last-name"));
            lastNameInput.SendKeys("xyz");
            Thread.Sleep(2000);

            IWebElement postalCodeInput = driver.FindElement(By.Name("postalCode"));
            postalCodeInput.SendKeys("560900");
            Thread.Sleep(2000);

            IWebElement continueButton = driver.FindElement(By.Id("continue"));
            continueButton.Click();

            IWebElement finishButton = driver.FindElement(By.Id("finish"));
            finishButton.Click();
            Thread.Sleep(2000);

            IWebElement thankYouSection = driver.FindElement(By.ClassName("complete-header"));
            Console.WriteLine(thankYouSection.Text);
            string expectedText = thankYouSection.Text;

            Assert.That(expectedText, Is.EqualTo("Thank you for your order!"));
            Thread.Sleep(2000);
        }
        [TearDown]
        public void tearDownrowser()
        {
            driver.Close();
        }
    }
}