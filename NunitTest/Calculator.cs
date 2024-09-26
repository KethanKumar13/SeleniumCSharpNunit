using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitSelenium.NunitTest
{
    internal class Calculator
    {
        public int Add(int a, int b)
        {
            int c = a + b;
            return c;
        }
        public int Sub(int a, int b)
        {
            int c = a - b;
            return c;
        }
    }
}
