// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VendingMachine.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace Algorithms
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// simulates a Money Vending machine that gives the change in minimum number of Notes.
    /// </summary>
    public class VendingMachine
    {
        /// <summary>
        /// Vending Machine this instance.
        /// </summary>
        public static void Vendingmachine()
        {
            int userMoney = 0;
            int numberOfNotes = 0;
            int[] notesDenomination = { 1000, 500, 100, 50, 10, 5, 2, 1 };

            bool loop = true; //// for keep asking for input till valid value of change is given.
            while (loop)
            {
                Console.WriteLine("Enter the Change in Rupees");
                string stringUserMoney = Console.ReadLine();

                if (Utility.IsNumber(stringUserMoney) == false)
                {
                    Console.WriteLine("Rupees should be in Positive Value");
                    continue;
                }

                userMoney = Convert.ToInt32(stringUserMoney);
                loop = false;
            }

            bool toWrite = false; //// for writing to console only if it is true;
            while (userMoney > 0)
            {
                for (int i = 0; i < notesDenomination.Length; i++)
                {
                    while (userMoney >= notesDenomination[i])
                    {
                        userMoney = userMoney - notesDenomination[i];
                        numberOfNotes = numberOfNotes + 1;
                        toWrite = true;
                    }

                    if (toWrite == true)
                    {
                        Console.WriteLine(notesDenomination[i] + " X " + numberOfNotes);
                        toWrite = false;
                        numberOfNotes = 0;
                    }
                }
            }
        }
    }
}
