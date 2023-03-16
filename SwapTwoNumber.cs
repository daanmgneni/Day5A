using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class SwapTwoNumber
    {
        public static void call()
        {
            Console.WriteLine("Enter the value of a");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of b");
            int b= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swap a = " +a+" b = " +b);
            a = a * b;
            b= a / b;
            a = a / b;
            Console.WriteLine("After Swap a = " + a + " b = " + b);
        }
    }
}
