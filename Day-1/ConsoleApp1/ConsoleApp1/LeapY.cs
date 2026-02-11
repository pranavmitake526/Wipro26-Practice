using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class LeapY
    {
        public void Check(int n)
        {
            if (n % 4 == 0 && n % 100 != 0)
            {
                Console.WriteLine("It's Leap Year");
            }else if (n % 400 == 0)
            {
                Console.WriteLine("It's Leap Year");
            } else
            {
                Console.WriteLine("It's Not Leap Year");
            }
        }
        static void Main()
        {
            int year;
            Console.WriteLine("Enter Year ");
            year = Convert.ToInt32(Console.ReadLine());
            LeapY leapY = new LeapY();
            leapY.Check(year);
        }
    }
}
