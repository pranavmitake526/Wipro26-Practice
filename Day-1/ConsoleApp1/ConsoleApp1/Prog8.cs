using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Prog8
    { 
        static void Main()
        {
            int x = 50;
            int y = x++ + ++x;
            Console.WriteLine(y);
        }
    }
}
