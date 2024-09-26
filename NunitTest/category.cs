using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.NunitTest
{
    [Allure.NUnit.AllureNUnit]
    internal class category
    {

        [Test, Category("Regression")]
        public void login()
        {
            Console.WriteLine("Logging into application");
        }

        [Test, Ignore("Defect ID 45667")]
        public void products()
        {
            Console.WriteLine("Logging into application");
        }
        [Test, Category("Regression")]
        public void addtocarts()
        {
            Console.WriteLine("products added to the cart");
        }
    }
}
