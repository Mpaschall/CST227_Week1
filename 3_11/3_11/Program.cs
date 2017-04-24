using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_11
{
    class Program
    {
        static void Main(string[] args)
        {
            double cerealA = 0;
            double cerealB = 0;
            double cheapCereal = 0;
            double milkA = 0;
            double milkB = 0;
            double cheapMilk = 0;
            double cost = 0;

            Console.WriteLine("Enter the cereal price at store A");
            cerealA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the cereal price at store B");
            cerealB = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the milk price at store A");
            milkA = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the milk price at store B");
            milkB = Convert.ToDouble(Console.ReadLine());

            if (cerealA < cerealB)
            {
                cheapCereal = cerealA;
            }
            else
            {
                cheapCereal = cerealB;
            }

            if (milkA < milkB)
            {
                cheapMilk = milkA;
            }
            else
            {
                cheapMilk = milkB;
            }

            cost = ((3 * cheapCereal) + (2 * cheapMilk));
            Console.WriteLine("The cheapest cost for these items is $" + cost);
        }
    }
}
