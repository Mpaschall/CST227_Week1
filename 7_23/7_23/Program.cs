using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_23
{
    class Program
    {
        static void Main(string[] args)
        {
            double sales = 0;
            double avg1 = 0;
            double avg2 = 0;
            double avg3 = 0;
            double avgTotal = 0;

            double[] region1 = new double[5];
            double[] region2 = new double[3];
            double[] region3 = new double[2];

            for (int i = 0; i < region1.Length; i++)
            {
                Console.WriteLine("Enter the sales for this store in region 1");
                region1[i] = Convert.ToDouble(Console.ReadLine());
            }

            avg1 = ((region1[0] + region1[1] + region1[2] + region1[3] + region1[4]) / 5);

            for (int j = 0; j < region2.Length; j++)
            {
                Console.WriteLine("Enter the sales for this store in region 2");
                region2[j] = Convert.ToDouble(Console.ReadLine());            
            }

            avg2 = ((region1[0] + region1[1] + region1[2]) / 3);

            for (int k = 0; k < region3.Length; k++)
            {
                Console.WriteLine("Enter the sales for this store in region 3");
                region3[k] = Convert.ToDouble(Console.ReadLine());
            }

            avg3 = ((region1[0] + region1[1]) / 2);

            avgTotal = ((avg1 + avg2 + avg3) / 3);

            Console.WriteLine("\nYour average sales in region 1 were " + avg1);
            Console.WriteLine("\nYour average sales in region 2 were " + avg2);
            Console.WriteLine("\nYour average sales in region 3 were " + avg3);
            Console.WriteLine("\nYour average sales in all regions were " + avgTotal);
        }
    }
}
