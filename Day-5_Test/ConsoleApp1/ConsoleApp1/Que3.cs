using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Que3
    {
        static void Main()
        {
            Console.WriteLine("Enter K value: ");
            int K = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter String");
            string str = Console.ReadLine();

            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                int count = 0;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;

                    }
                }
                if (count == K)
                {
                    sb.Append(str[i]);

                }
            }
            string pranav = sb.ToString();
            Console.WriteLine("Char which is equal to K :");
            Console.WriteLine(pranav);

            StringBuilder sb1 = new StringBuilder(str);
            sb1.Replace(pranav,"");
            Console.WriteLine("After removing K occurance: ");
            Console.WriteLine(sb1.ToString());
            
        }
    }
}
