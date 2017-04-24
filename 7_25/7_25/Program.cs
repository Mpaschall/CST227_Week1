using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_25
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int x = 0;
            double tempP = 0;
            double p = 0;

            Console.WriteLine("Please enter the number of integers you would like to partition");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a number to partition at");
            x = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[n];
            tempP= ((n / 2));
            Math.Round(p);

            for (int k = 0; k < array.Length; k++)
            {
                Console.WriteLine("Please enter a number to add to the array.");
                array[k] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i <= p; i++)
            {
                int j = array.Length - 1;
                while (j > p)
                {
                    if (array[i] > x && array[j] < x)
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                    j--;
                }
            }    
           
            Console.WriteLine("The partitioned array is");
            Console.WriteLine(string.Join(",", array));
        }
    }
}
