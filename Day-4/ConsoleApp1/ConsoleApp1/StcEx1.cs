using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class StcEx1
    {
        static void Main()
        {
            Stack stack = new Stack();
            stack.Push("Pranav");
            stack.Push("Harshvardhan");
            stack.Push("Kamalesh");
            stack.Push("Sanjay");
            stack.Push("Adhiraj");

            Console.WriteLine("Stack Data  ");
            foreach (object ob in stack)
            {
                Console.WriteLine(ob);
            }
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine("Stack Data After Pop Operation  ");
            foreach (object ob in stack)
            {
                Console.WriteLine(ob);
            }
        }
    }
}
