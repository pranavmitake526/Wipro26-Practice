using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Training
    {
        public abstract void Name();
        public abstract void Email();
    }

    class Aman : Training
    {
        public override void Email()
        {
            Console.WriteLine("Email is Amandesai@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("Hi I am Aman boss.");
        }
    }

    class Neerav : Training
    {
        public override void Email()
        {
            Console.WriteLine("Email is Neerav526@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("Hi I am Neerav Vivek boss.");
        }
    }

    class Ritwik : Training
    {
        public override void Email()
        {
            Console.WriteLine("Email is Ritwik526@gmail.com");
        }

        public override void Name()
        {
            Console.WriteLine("Hi I am Ritwik boss.");
        }
    }
    internal class AbCoEx2
    {
        static void Main()
        {
            //Training obj1 = new Ritwik();
            //Training obj2 = new Aman();
            //Training obj3 = new Neerav();

            Training[] arr = new Training[]
            {
                new Ritwik(), new Aman(), new Neerav()
            };

            foreach (Training training in arr)
            {
                training.Name();
                training.Email();
            }
        }
    }
}
