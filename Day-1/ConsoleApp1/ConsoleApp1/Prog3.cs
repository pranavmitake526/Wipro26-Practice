using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Prog3
    {
        static void Main()
        {
            string sname;
            string city;
            string company;
            Console.WriteLine("Enter Your Name:");
            sname = Console.ReadLine();
            Console.WriteLine("Enter City Name:");
            city = Console.ReadLine();
            Console.WriteLine("Enter Company Name");
            company = Console.ReadLine();

            Console.WriteLine("Name is " +sname);
            Console.WriteLine("City is " +city);
            Console.WriteLine("Company is " +company);
            

        }
    }
}
