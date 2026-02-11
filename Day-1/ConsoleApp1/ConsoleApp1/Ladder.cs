using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Ladder
    {
        public void Check(int choice)
        {
            if(choice == 1)
            {
                Console.WriteLine("I am Pranav.");
            }else if (choice == 2)
            {
                Console.WriteLine("I am Raja.");
            }else if (choice == 3)
            {
                Console.WriteLine("I am Rahul.");
            }else if (choice == 4)
            {
                Console.WriteLine("I am Virat.");
            }
            else
            {
                Console.WriteLine("Invalid Choice");
            }
        }
        static void Main()
        {
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());

            Ladder ladder = new Ladder();
            ladder.Check(choice);

        }
    }
}
