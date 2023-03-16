using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class QuotientAndRemainder
    {
        public static void call()
        {
            int dividend = 67, divisior = 5;
            int Remainder = dividend % divisior;
            int Quotient = dividend / divisior;
            Console.WriteLine($"dividend is {dividend} and the divisior is {divisior}");
            Console.WriteLine($"Quotient is {Quotient} and the remainder is {Remainder}");
        }
    }
}
