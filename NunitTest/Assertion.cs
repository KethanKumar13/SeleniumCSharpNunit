using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.NunitTest

{

    [Allure.NUnit.AllureNUnit]
    internal class Assertion
    {
        [Test]
        public void Testassertion()
        {
            string actual = "google";

            string expected = "yahoo";

            /*if (actual == expected)
            {
                Console.WriteLine("the resut are matchinng");
            }
            else
            {
                Console.WriteLine("the resultare not matching");
            }*/
            // assert equal

            Assert.AreEqual(actual, expected);

            //Assert.AreNotEqual(actual, expected);

            Assert.That(actual, Is.EqualTo(expected));

            Assert.That(actual, Is.Not.EqualTo(expected));

            //assert for string ignore case

            Assert.That(actual, Is.EqualTo(expected).IgnoreCase);


            //sbstrig presrenece

            Assert.That(actual, Does.Contain("def").IgnoreCase);

            Assert.That(actual, Does.Not.Contain("def").IgnoreCase);

           

        }
    }
}
