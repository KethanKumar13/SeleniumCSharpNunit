using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;

namespace NunitSelenium.Assignment
{
    [Allure.NUnit.AllureNUnit]
    internal class Parabank
    {
        IWebDriver driver;


        [SetUp]
        public void startbrowser()
        {

            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            //Initialize web driver
            driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://parabank.parasoft.com/parabank/register.html");
            driver.Manage().Window.Maximize();

        }

        [Test,Order(1), Category("Regesteration")]
        public void paratest()
        {
            IWebElement reg = driver.FindElement(By.LinkText("Register"));

            reg.Click();

            Thread.Sleep(1000);

            IWebElement Fname = driver.FindElement(By.XPath("//input[@id='customer.firstName']"));
            
            Thread.Sleep(1000);
            Fname.SendKeys("Kethan");


            IWebElement Lname = driver.FindElement(By.XPath("//input[@id='customer.lastName']"));
           
            Thread.Sleep(1000);
            Lname.SendKeys("Kumar");

            IWebElement add = driver.FindElement(By.XPath("//input[@id='customer.address.street']"));
            Thread.Sleep(1000);
            add.SendKeys("Bejai");


            IWebElement city = driver.FindElement(By.XPath("//input[@id='customer.address.city']"));
            Thread.Sleep(1000);
            city.SendKeys("Mangalore");

            IWebElement state = driver.FindElement(By.XPath("//input[@id='customer.address.state']"));
            Thread.Sleep(1000);
            state.SendKeys("Karnataka");

            IWebElement zip = driver.FindElement(By.XPath("//input[@id='customer.address.zipCode']"));
            Thread.Sleep(1000);
            zip.SendKeys("575025");

            IWebElement phone = driver.FindElement(By.XPath("//input[@id='customer.phoneNumber']"));
            Thread.Sleep(1000);
            phone.SendKeys("6567897677");


            IWebElement ssn = driver.FindElement(By.XPath("//input[@id='customer.ssn']"));
            Thread.Sleep(1000);
            ssn.SendKeys("abc123");


            IWebElement uname = driver.FindElement(By.XPath("//input[@id='customer.username']"));
            Thread.Sleep(1000);
            uname.SendKeys("kethan");

            IWebElement pass = driver.FindElement(By.XPath("//input[@id='customer.password']"));
            Thread.Sleep(1000);
            pass.SendKeys("123456");

            IWebElement con = driver.FindElement(By.XPath("//input[@id='repeatedPassword']"));
            Thread.Sleep(1000);
            con.SendKeys("123456");


            IWebElement regis = driver.FindElement(By.XPath("//input[@value='Register']"));
            regis.Click();
            Thread.Sleep(4000);
           
        }

        [Test, Order(2), Category("Login")]
        public void paratest1()
        {
            IWebElement userlogin = driver.FindElement(By.XPath("//input[@name='username']"));
            Thread.Sleep(1000);
            userlogin.SendKeys("kethan");

            IWebElement userpass = driver.FindElement(By.XPath("//input[@name='password']"));
            Thread.Sleep(1000);
            userpass.SendKeys("123456");

            IWebElement login = driver.FindElement(By.XPath("//input[@value='Log In']"));

            login.Click();

            Thread.Sleep(1000);


        }


        [TearDown]
        public void tearDownbrowser()
        {

            driver.Close();

        }
    }
}
