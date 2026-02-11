using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LoopEx1
    {
        public void Check()
        {
            int i = 0;
            int count = 10;
            while(i < count)
            {
                Console.WriteLine("I am Pranav");
                i++;
            }
        }
        static void Main()
        {
            LoopEx1 loopEx1 = new LoopEx1();
            loopEx1.Check();
        }
    }
}
