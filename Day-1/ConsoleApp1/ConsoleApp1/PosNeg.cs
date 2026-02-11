using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class PosNeg
    {
        public void Check(int n)
        {
            if(n >= 0)
            {
                Console.WriteLine("Number is Positive");

            } else
            {
                Console.WriteLine("Number is Negative");
            }
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter Number");
            n = Convert.ToInt32(Console.ReadLine());

            PosNeg posNeg = new PosNeg();
            posNeg.Check(n);

        }
    }
}
