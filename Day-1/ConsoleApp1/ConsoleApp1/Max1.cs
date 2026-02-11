using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Max1
    {
        public void Check(int a, int b, int c)
        {
            int m = a;
            if(m < b)
            {
                m = b;
            }
            if(m < c)
            {
                m = c;
            }
            Console.WriteLine("Maximum in 3 numbers is: " +m);

        }
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter 3 Numbers");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            Max1 max = new Max1();
            max.Check(a, b, c);
        }
    }
}
