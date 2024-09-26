using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NunitSelenium.NunitTest;
using NunitSelenium.Utilities;
using OpenQA.Selenium;

namespace NunitSelenium.DataDrivenTesting
{
    internal class TestParaforLogin : Base
    {
        [TestCase("Admin", "admin123")]
        /*        [TestCase("Kethan", "asdfg123")]
                [TestCase("Sam", "qwert")]*/
        public void testcase1(string user, string pass)
        {
            Thread.Sleep(1000);

            IWebElement Username = driver.FindElement(By.Name("username"));
            Username.SendKeys(user);

            Thread.Sleep(4000);

            IWebElement Password = driver.FindElement(By.Name("password"));
            Password.SendKeys(pass);

            IWebElement LoginButton = driver.FindElement(By.XPath("//button [@type = 'submit']"));
            LoginButton.Click();

        }
    }
}
