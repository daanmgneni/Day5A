using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class power_2
    {
         public static void call()
        {
            Console.WriteLine("Enter the value of n: ");
             int n = Convert.ToInt32(Console.ReadLine());
             if(n<0 || n>=31)
            {
                Console.WriteLine("Invalid no.Please enter valid input!");
            }
            for (int i = 0; i < n; i++)
            {
                int pow = (int)Math.Pow(2, i);
                Console.WriteLine("so the value of 2 ^ {0} is = {1}",i, pow);
            }

        }

    }
}
