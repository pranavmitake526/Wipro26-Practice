using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class CaseEx1
    {
        public void Check(int age)
        {
            if(age >= 18)
            {
                Console.WriteLine("Eligible to vote");
            } else
            {
                Console.WriteLine("Not eligible to vote");
            }
        }
        static void Main()
        {
            int age;
            Console.WriteLine("Enter Age");
            age = Convert.ToInt32(Console.ReadLine());
            CaseEx1 caseEx1 = new CaseEx1();
            caseEx1.Check(age);

        }
    }
}
