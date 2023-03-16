using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class basics
    {
        public static void display()
        {
            display1();
            int a = 10;
            int b= 20;
            int c = a + b; 
            Console.WriteLine("value of a & b:" + a+b);
            Console.WriteLine(c);
            Random random = new Random();
            int n= random.Next(2);
            Console.WriteLine(n);

        }
        private static void display1()
        {
            Console.WriteLine("hello how are you?");
        }
       
    }
}
