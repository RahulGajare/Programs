using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructures.BankingCashCounter
{
    class TransactionInput
    {
        public static void DepositeDetails(Person person)
        {
            bool loopDeposite = true;

            while (loopDeposite)
            {
                Console.WriteLine("Enter the Money you want to Deposite,You have currently " + person.Balance + " in your account");
                string amountToDeposite = Console.ReadLine();

                if (utility.IsNumber(amountToDeposite) == false)
                {
                    Console.WriteLine("Invalid Input");
                    continue;

                }

                if (person.Deposite(Convert.ToInt32(amountToDeposite)) == false)
                {
                    continue;
                }

                loopDeposite = false;
            }


        }


        public static void WithdrawlDetails(Person person)
        {
            bool loopWithdraw = true;
            while (loopWithdraw)
            {
                Console.WriteLine("Enter the Money you want to Withdraw,You have currently " + person.Balance + " in your account");
                string amountToWithdraw = Console.ReadLine();

                if (utility.IsNumber(amountToWithdraw) == false)
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }

                if (person.Withdraw(Convert.ToInt32(amountToWithdraw)) == false)
                {
                    continue;
                }

                loopWithdraw = false;
            }

            

        }



    }
}
