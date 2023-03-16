using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class leapyear
    {
    
            public static void year()
            {
                Console.WriteLine("Enter the year:");
                int year = Convert.ToInt32(Console.ReadLine());

                if (year.ToString().Length != 4)
                {
                    Console.WriteLine("Please enter a 4 digit year.");
                    return;
                }

                if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                {
                    Console.WriteLine(year + " is a leap year.");
                }
                else
                {
                    Console.WriteLine(year + " is not a leap year.");
                }
            }
        

    }
}
