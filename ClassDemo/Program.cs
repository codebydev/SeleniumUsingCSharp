using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            acc1.ShowBalance();
            //acc1.Deposit();
            //acc1.ShowBalance();
            //acc1.Withdraw();
            //acc1.ShowBalance();

            Account acc2 = new Account(20000);
            acc2.ShowBalance();

        }
    }
    // Types of constructors
    // 1. default, 2. parameterized 3. copy 4. static 5. private
    // Types of access specifiers
    // public private protected internal protected internal
    class Account
    {
        private int balance;
        private string name;

        public Account()
        {
            Console.WriteLine("Default constructor");
            balance = 5000;
        }

        public Account(int initialBalance)
        {
            Console.WriteLine("Parameterized contructor");
            balance = initialBalance;
        }

        public void ShowBalance()
        {
            Console.WriteLine("The balance is "+balance);
        }

        public void Deposit()
        {
            Console.WriteLine("Enter the amount to be deposited");
            int d = int.Parse(Console.ReadLine());
            balance += d;
        }

        public void Withdraw()
        {
            Console.WriteLine("Enter the amount to be withdrawn");
            int w = int.Parse(Console.ReadLine());
            balance -= w;
        }
    }
}
