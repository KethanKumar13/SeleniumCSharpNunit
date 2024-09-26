using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.DataDrivenTesting
{
    internal class TestPartUsingTestcase
    {
        
        [TestCase("abc.com","ghhjj")]
        [TestCase("ghh.com", "fghhj")]
        [TestCase("mkk.com", "ddffg")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + ":" + password);
        }

    }
}
