using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Prog5
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Enter 2 Numbers   ");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            c = a + b;
            Console.WriteLine("Sum is  " + c);

            c = a - b;
            Console.WriteLine("Substraction is  " + c);

            c = a * b;
            Console.WriteLine("Multiplication is  " + c);
        }
    }
    
}
