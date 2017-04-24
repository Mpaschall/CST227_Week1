using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_11
{
    class Program
    {
        static string x = "";
        static int y = 0;
        static int z = 0;

        public static string lowerCase(string x)
        {
            return x.ToLower();
        }

        public static string trimIt(string x)
        {
            return x.Trim();
        }

        public static string sub(int y, int z)
        {
            return x.Substring(y, z);
        }
        static void Main(string[] args)
        {
            string answer = "";

            Console.WriteLine("Please enter a string");
            x = Console.ReadLine();

            Console.WriteLine("What would you like to do with this string?" 
                + "/nlowercase, trim, substring");

            answer = Console.ReadLine();

            if (answer.Equals("lowercase"))
            {
                Console.WriteLine("lowercase is " + lowerCase(x));
            }
            else if (answer.Equals("trim"))
            {
                
                Console.WriteLine("trimmed is " + trimIt(x));
            }
            else if (answer.Equals("substring"))
            {
                Console.WriteLine("enter the starting position in the string");
                y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("enter the amount of characters to include");
                z = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Substring is " + sub(y, z));
            }
            
        }
    }
}
