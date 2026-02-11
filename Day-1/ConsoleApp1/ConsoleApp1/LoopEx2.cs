using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LoopEx2
    {
        public void Check(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    Console.WriteLine("Factos is " +i);
                }
            }
        }
        static void Main()
        {
            int n;
            Console.WriteLine("Enter Number ");
            n = Convert.ToInt32(Console.ReadLine());

            LoopEx2 loopEx2 = new LoopEx2();
            loopEx2.Check(n);
        }
    }
}
