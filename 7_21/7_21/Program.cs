using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_21
{
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0;
            int randNum = 0;
            double mean = 0;
            double difference = 0;
            double diffSquare = 0;
            double avgSquare = 0;
            double root = 0;

            double[] array = new double[5];
            double[] diffArray = new double[5];
            double[] diffSquareArr = new double[5];

            Random rnd = new Random();
            for (int h = 0; h < array.Length; h++)
            {
                randNum = rnd.Next(1, 99);
                num = randNum * 1.25;
                array[h] = num;
                Console.WriteLine("Your number at " + h + " is " + num);
            }

            mean = ((array[0] + array[1] + array[2] + array[3] + array[4]) / 5);

            for (int i = 0; i < array.Length; i++)
            {
                difference = ((array[i] - mean));
                diffArray[i] = difference;
                Console.WriteLine("The difference at " + i + " is " + difference);
            }
            
            for (int j = 0; j < diffArray.Length; j++)
            {
                diffSquare = (diffArray[j] * diffArray[j]);
                diffSquareArr[j] = diffSquare;
                Console.WriteLine("The square of the difference at " + j 
                    + " is " + diffSquare);
            }

            avgSquare = ((diffSquareArr[0] + diffSquareArr[1] + diffSquareArr[2]
                + diffSquareArr[3] + diffSquareArr[4]) / 5);

            root = Math.Sqrt(avgSquare);
            
            Console.WriteLine("The mean is " + mean);
            Console.WriteLine("\nThe Average of the squares is " + avgSquare);
            Console.WriteLine("\nThe square root is " + root);
        }
    }
}
