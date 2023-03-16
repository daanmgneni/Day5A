using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class LargestNumber
    {
        public static void call()
        {
            Console.WriteLine("Enter the value of num1");
            int  num1= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of num2");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of num3");
            int num3 = Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"num1 ({num1})is largest");
                }
            }
            else if (num2 > num3)
            {
                Console.WriteLine($"num2 ({num2}) is largest");
            }
            else
            {
                Console.WriteLine($",num3 ({num3})  is largest");
            }

        }

    }
}
