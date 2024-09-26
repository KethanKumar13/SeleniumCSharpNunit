using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.NunitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class UnitTestCalculatorTeardown
    {
        public Calculator cl;
        [SetUp]
        public void setup() 
        {
            cl = new Calculator();
            Console.WriteLine("executing setup");


        }


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

        public void teardown()
        {
            Console.WriteLine(" all the unit test are completed");
        }
    }
}
