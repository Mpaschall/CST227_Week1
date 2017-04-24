using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int[] array = new int[20];
            Random randNum = new Random(DateTime.Now.Millisecond);

            for (int i =0; i < array.Length; i++)
            {
                
                num = randNum.Next(0, 9);
                array[i] = num;
                Console.WriteLine("" + num);
            }
            if (!array.Contains(7))
            {
                Console.WriteLine("There are no 7's in this array");
            }

            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == 7)
                {
                    Console.WriteLine("The first 7 is at " + j);
                    break;
                }
            }
        }
    }
}
