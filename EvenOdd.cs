using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class EvenOdd
    {
        public static void call() 
        {
            Console.WriteLine("Enter the number:");
            int num =Convert.ToInt32(Console.ReadLine());
           
                if (num % 2 == 0)
                {
                    Console.WriteLine($"Your given no.{num} is even");
                }
                else
                {
                    Console.WriteLine($"Your given no.{num} is odd");
                }
                     

        }
    }
}
