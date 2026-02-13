using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Que2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter line to check: ");
            string sentence = Console.ReadLine();

            sentence = sentence.ToLower();
            StringBuilder sb = new StringBuilder();
            foreach (char ch in sentence)
            {
                if (char.IsLetterOrDigit(ch))
                {
                    sb.Append(ch);
                }
            }
            string original = sb.ToString();

            char[] arr = original.ToCharArray();
            Array.Reverse(arr);
            string reversed = new string(arr);

            if (original == reversed)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }

        }
    }
}
