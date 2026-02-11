using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LoopEx3
    {
        public void Check(int n)
        {
            int f = 1;
            int i = 1;
            while (i <= n)
            {
                f = f * i;
                i++;
            }
            Console.WriteLine("Factorial is "+f);
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter Number");
            n = Convert.ToInt32(Console.ReadLine());
            LoopEx3 loopEx3 = new LoopEx3();
            loopEx3.Check(n);
        }
    }
}
