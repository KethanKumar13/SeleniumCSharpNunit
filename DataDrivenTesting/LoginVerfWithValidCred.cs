using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NunitSelenium.Utilities;
using OpenQA.Selenium;

namespace NunitSelenium.DataDrivenTesting
{
    internal class LoginVerfWithValidCred : Base
    {
        [TestCase("Admin", "admin123")]

        public void testcase1(string user, string pass)
        {
            Thread.Sleep(3000);

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
