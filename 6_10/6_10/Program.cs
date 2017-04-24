using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_10
{
    class Program
    {
        private double balance;

        public Program()
        {
            balance = 0;
        }

        public Program(double initialAmount)
        {
            balance = initialAmount;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public double Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return balance;
            }
            else
                return -1.0;
        }

        public string Person(string name)
        {
            return name;
        }

            static void Main(string[] args)
        {
        }
    }
}
