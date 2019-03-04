// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="StartCommercial.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.Commercial_Data_Processing
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// StartCommercial Class
    /// </summary>
    public class StartCommercial
    {
        /// <summary>
        /// Starts  the shares.
        /// </summary>
        public static void InitialiseShares()
        {
            StockAccount stockAccount = new StockAccount();
            while (true)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1) To buy Share");
                Console.WriteLine("2) To Sell a Share");
                Console.WriteLine("3) To view Existing Shares");
                Console.WriteLine("4) View Stock Symobol Purchased");
             
                string stringOption = Console.ReadLine();

                if (Utility.IsNumber(stringOption) == false)
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                int option = Convert.ToInt32(stringOption);
                
                //// Calls the method based on choosen option by the user.
                switch (option)
                {
                    case 1:
                        {
                            UserInput.TakeUserInput(option);
                            break;
                        }

                    case 2:
                        {
                            UserInput.TakeUserInput(option);
                            break;
                        }

                    case 3:
                        {
                            stockAccount.PrintReport();
                            break;
                        }

                    case 4:
                        {
                            StockAccount stockaccount = new StockAccount();
                            stockaccount.PrintSymbols();
                            break;
                        }

                    default:
                        {
                            Console.WriteLine("Invalid Input");
                            break;
                        }
                }            
            }
        }
    }
}
