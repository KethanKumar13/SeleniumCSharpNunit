using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;

namespace NunitSelenium.Selenium
{
    internal class DownloadFile
    {
        ChromeDriver driver;

        [SetUp]
        public void setUp()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
            driver.Manage().Window.Maximize();

        }

        [TearDown]
        public void Teardown()
        {
            driver.Close();
        }

        [Test]
        public void downloadFileFunc()
        {
            IWebElement file = driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/a[8]"));
            file.Click();
            Thread.Sleep(5000);

            string text = file.Text;
            string path = "C:\\Users\\kekum\\Downloads\\" + text;
            Console.WriteLine(path);
            Assert.That(File.Exists(path));
        }
    }
}
