using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class QueEx
    {
        static void Main()
        {
            Queue queue = new Queue();

            queue.Enqueue("Rohit");
            queue.Enqueue("Harsh");
            queue.Enqueue("Pranav");
            queue.Enqueue("Raja");
            queue.Enqueue("Tommy");

            Console.WriteLine("Queue Data are  ");
            foreach (object ob in queue)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
