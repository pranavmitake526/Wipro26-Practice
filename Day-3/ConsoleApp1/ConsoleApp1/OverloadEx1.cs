using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class OverloadEx1
    {
        public void Show(int x)
        {
            Console.WriteLine("Show Method Integer  " + x);
        }

        public void Show(double x)
        {
            Console.WriteLine("Show Method Double  " + x);
        }

        public void Show(string x)
        {
            Console.WriteLine("Show Method String  " + x);
        }
        static void Main()
        {
            OverloadEx1 overloadEx1 = new OverloadEx1();
            overloadEx1.Show(102);
            overloadEx1.Show(212.5);
            overloadEx1.Show("Wipro");
        }
    }
}
