using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the number of integers you would like to compare.");
            int x = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[x];

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine("Please enter a number to compare.");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("The largest number is " + array.Max());
        }
    }
}
