using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2.Extensions
{
    public static class NumberEvenExtension
    {
        public static bool IsNumberEven(this int number)
        {
            return number % 2 == 0;
        }
    }
}
