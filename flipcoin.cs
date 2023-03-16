using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    public class flipcoin
    {
        public static void flipthecoin()
        {
            int head = 0;
            int tail = 0;
            double headPercentage = 0;
            double tailPercentage = 0;
            Console.WriteLine("Please Enter The no. of Flips:");
            int flip = Convert.ToInt32(Console.ReadLine());

            if (flip > 0)
            {
                for (int i = 0; i < flip; i++)
                {
                    Random random = new Random();
                    int num = random.Next(2);
                    Console.WriteLine("random no genrated by system is" + num);
                    if (num == 0)
                    {
                        Console.WriteLine("It is tail");
                        tail++;
                    }
                    else
                    {
                        Console.WriteLine("It is head");
                        head++;
                    }
                }
                Console.WriteLine("The count of head is" + head);
                Console.WriteLine("The count of tail is" + tail);
                headPercentage = head * 100 / flip;
                tailPercentage = tail * 100 / flip;
                Console.WriteLine("percentage of head is" + headPercentage);
                Console.WriteLine("percentage of tail is" + tailPercentage);

            }
            
        }
    }
}
