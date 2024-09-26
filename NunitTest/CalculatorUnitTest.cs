using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.NunitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class CalculatorUnitTest
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

        Calculator cl = new Calculator();


        [Test]
        public void TestAdd()
        {
            int result = cl.Add(2, 3);

            int result1 = cl.Add(3, -4);

            // Assetion
            Assert.AreEqual(5, result);

            Assert.AreEqual(-1, result1);
        }
        [Test]
        public void TestSub()
        {
            int result = cl.Sub(8, 3);

            int result1 = cl.Sub(9, 5);

            // Assetion
            Assert.AreEqual(5, result);

            Assert.AreEqual(4, result1);
        }
        

    }
}
