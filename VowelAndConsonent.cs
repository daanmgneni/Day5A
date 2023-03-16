using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helloworld
{
    internal class VowelAndConsonent
    {
        public static void call()
        {
            Console.WriteLine("Enter the character:");
            char ch=Convert.ToChar(Console.ReadLine());
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' ||
                ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                Console.WriteLine("Your given character " + ch + " is vowel");
            }
            else if((ch>'a' && ch<='z') || (ch>='A' &&  ch <= 'Z'))
            {
                Console.WriteLine("Your given character " + ch + " is not vowel only consonant");
            }
        }
    }
}
