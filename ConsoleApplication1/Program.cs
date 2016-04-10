using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mlamb.Cipher;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] strings = { "abcdefghijklmnopqrstuvwxyz", "This is a string", "This is also a string", "Here we change some text", "Text some change we here", "adding punctuation!.?" };
            foreach (string str in strings)
            {
                Console.WriteLine(str);
                foreach (char letter in str)
                {
                    Console.Write(Caesar.Encrypt(letter, 3));
                }
                Console.Write("\n");
            }
            string string2 = "defghijklmnopqrstuvwxyzabc";
            foreach (char c in string2)
            {
                Console.Write(Caesar.Decrypt(c, 3));
            }
            
            Console.ReadLine();
        }
    }
}
