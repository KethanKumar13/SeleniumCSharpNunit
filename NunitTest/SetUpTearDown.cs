using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.NunitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class SetUpTearDown
    {
        [SetUp]
        public void setup()
        {
            Console.WriteLine("Lanching chrome browser");
        }
        [TearDown]

        public void teardown()
        {
            Console.WriteLine("closing the chrome browerse");

        }



        [Test, Order(1)]
        public void login()
        {
            Console.WriteLine("Logging into application");
        }

        [Test, Order(2)]
        public void products()
        {
            Console.WriteLine("Logging into application");
        }
        [Test, Order(3)]
        public void addtocarts()
        {
            Console.WriteLine("products added to the cart");
        }

    }
}
