using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BankingCashCounter
{
    class Person
    {
        private string name;
        private double balance;

        public Person(string name, int balance)
        {
            this.name = name;
            if (balance < 0)
            {
                Console.WriteLine("Please provide a positive value for balance");
                return;
            }

            this.balance = balance;

        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public double Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public bool Deposite(int depositeAmount)
        {
            if (depositeAmount <= 0)
            {
                Console.WriteLine("Please Provide a positive value for amount to deposite");
                Console.ReadKey();
                return false;
            }

            balance = balance + depositeAmount;
            Console.WriteLine("your total Balance = " + balance);
            return true;
        }

        public bool Withdraw(int withdrawAmount)
        {
            if (withdrawAmount > balance)
            {
                Console.WriteLine("You dont have enough money in your Account");
                Console.ReadKey();
                return false;
           
            }

            balance = balance - withdrawAmount;
            Console.WriteLine("Remaining balance = "+ balance);
            return true;
       
        }
    }
}
