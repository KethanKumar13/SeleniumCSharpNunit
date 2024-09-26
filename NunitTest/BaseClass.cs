using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.NunitTest
{
    [Allure.NUnit.AllureNUnit]
    [SetUpFixture]
    internal class BaseClass
    {
        [OneTimeSetUp]
        public void dbconnectionopen()
        {
            TestContext.Progress.WriteLine("opening of database");
            

        }


        [OneTimeTearDown]
        public void dbconnectionclose()
        {
            Console.WriteLine("closing the db ");
        }  
    }
}
