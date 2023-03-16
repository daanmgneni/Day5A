using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class PerfectNumber
    {
        public static void FindPerNumber()
        {
            int n, i, sum;
            int mn, mx;
            Console.WriteLine("Find the perfect number with ina given no. of range");
            Console.WriteLine("Input the starting range of number");
            mn=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the ending range of number");
            mx=Convert.ToInt32(Console.ReadLine());

            for (n = mn; n < mx; n++)
            {
                i = 1;
                sum=0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum += i;
                    i++;
                }
                if (sum == n)
                    Console.WriteLine(n);
            }
        }
    }
}
