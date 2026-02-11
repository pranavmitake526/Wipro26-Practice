using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    internal class OddEven
    {
        public void Check(int n)
        {
            if(n % 2 == 0)
            {
                Console.WriteLine("Number is Even");
            } else
            {
                Console.WriteLine("Number is Odd");
            }
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter Number");
            n = Convert.ToInt32(Console.ReadLine());

            OddEven oddEven = new OddEven();
            oddEven.Check(n);
        }
    }
}
