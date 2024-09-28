using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.NunitTest

{

    //[Allure.NUnit.AllureNUnit]
    internal class Assertion
    {
        [Test]
        public void TestAssertion()
        {
            string actual = "google";
            string expected = "yahooo";

            // Assert that actual is not equal to expected
            Assert.AreNotEqual(actual, expected);

            // Assert that actual is not equal to expected using Assert.That
            Assert.That(actual, Is.Not.EqualTo(expected));

            // Assert for string equality ignoring case (this will fail)
            Assert.That(actual, Is.Not.EqualTo(expected).IgnoreCase);

            // Assert that actual contains a substring (this will fail)
            Assert.That(actual, Does.Not.Contain("def").IgnoreCase);
        }
    }
}