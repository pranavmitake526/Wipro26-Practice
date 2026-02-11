using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class BoxEx2
    {
        static void Main()
        {
            int[] a = new int[] { 11, 12, 13, 14 };
            int[] b = new int[] { 5, 6, 7, 8 };
            int[] c = new int[] { 18, 19, 12,22,12 };
            
            int[][] jag = new int[3][];

            jag[0] = a;
            jag[1] = b;
            jag[2] = c;

            Console.WriteLine("Jagged Array Data is  ");

            for (int i = 0; i < jag.Length; i++)
            {
                Console.WriteLine("Row  " + i + ":   ");
                foreach (int n in jag[i])
                {
                    Console.Write(n + "   ");
                }
                Console.WriteLine();
            }
        }
    }
}
