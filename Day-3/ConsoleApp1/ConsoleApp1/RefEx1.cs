using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class RefEx1
    {
        public void Calc(int x, ref int f)
        {
            for (int i = 1; i <= x; i++)
            {
                f = f * i;
            }
        }
        static void Main()
        {
            int x = 8;
            int f = 1;
            RefEx1 refEx1 = new RefEx1();
            refEx1.Calc(x, ref f);
            Console.WriteLine($"Factorial Value  {f}");
        }
    }
}
