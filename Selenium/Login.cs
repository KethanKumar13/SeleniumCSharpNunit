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
    internal class Login
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

            Thread.Sleep(3000);

            //single check box

            Thread.Sleep(1000);
            IReadOnlyList<IWebElement> Checkboxes = driver.FindElements(By.XPath("//input[@type = 'radio']"));

            foreach(IWebElement e in Checkboxes)
            {
                //fetchs the text of the element
                Console.WriteLine(e.Text);
                //click on the check boxes one by one
                e.Click();
                Thread.Sleep(3000);

            }

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
