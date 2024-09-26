using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.NunitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class Description
    {
        [Test]
        [Description("testcase verify the login function")]
        public void testcase1()
        {
            Console.WriteLine("This the first testcase");
        }
    }
}
