using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_13
{
    class Program
    {       
        static void Main(string[] args)
        {
            string checker = "e";
            string entered = "";
            int count = 0;

            Console.WriteLine("Please enter a string to check.");
            entered = Console.ReadLine();

            for (int i = 0; i < entered.Length; i++)
            {
                if (entered.Substring(i, 1).Equals(checker))
                {
                    count++;
                }
                else
                {
                }
            }
            Console.WriteLine("There are " + count + " letter e's in this string");
        }
    }
}
