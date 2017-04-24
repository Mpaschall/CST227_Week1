using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_9
{
    class Program
    {
        static void Main(string[] args)
        {
            double pay = 7.50;
            double oT = 11.25;
            double hours = 0;
            double payedMoney = 0;

            Console.WriteLine("Enter the number of hours worked");
            hours = Convert.ToDouble(Console.ReadLine());
            if (hours < 40)
            {
                payedMoney = pay * hours;
                Console.WriteLine("Your pay is " + payedMoney);
            }
            else if (hours > 40)
            {
                payedMoney = (((hours - 40) * 11.25) + (40 * pay));
                Console.WriteLine("Your pay is " + payedMoney);
            }
        }
    }
}
