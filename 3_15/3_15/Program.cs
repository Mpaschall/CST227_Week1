using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            double grade = 0;
            double totalGrade = 0;
            double gPA = 0;

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine("Please enter a test score. -1 to exit");
                grade = Convert.ToDouble(Console.ReadLine());               

                if (grade < 0)
                {
                    break;
                }
                totalGrade += grade;
                count++;
            }
            double avgGrade = (totalGrade / count);
            if (avgGrade >= 90 && avgGrade <= 100)
            {
                gPA = 4.0;
            }
            else if (avgGrade >= 80 && avgGrade <= 89.99)
            {
                gPA = 3.0;
            }
            else if (avgGrade >= 70 && avgGrade <= 79.99)
            {
                gPA = 2.0;
            }
            else if (avgGrade >= 60 && avgGrade <= 69.99)
            {
                gPA = 1.0;
            }
            else if (avgGrade >= 0 && avgGrade <= 59.99)
            {
                gPA = 0;
            }

            Console.WriteLine("Your GPA is " + gPA);
        }
    }
}
