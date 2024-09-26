using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.NunitTest
{
    [Allure.NUnit.AllureNUnit]
    [Parallelizable(ParallelScope.All)]
    internal class ParallelExecution
    {

        [Test]
        public void Login() {
            Console.WriteLine("Login ");

        }

        [Test]
        public void Logout()
        {
            Console.WriteLine("products");
        }

    }
}
