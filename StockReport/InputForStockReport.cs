// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="InputForStockReport.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.StockReport
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// InputForStockReport Class    /// </summary>
    public class InputForStockReport
    {
        /// <summary>
        /// Starts the stock report.
        /// </summary>
        public static void StartStockReport()
        {
            int numberOfStocks = 0;
            string stockName = string.Empty;
            int numberOfShares = 0;
            double priceOfShares = 0;

            ////This Arraylist for storing the objects of Stocks after taking the details for each stock 
            ArrayList stockList = new ArrayList(); 

            while (true)
            {
                Console.WriteLine("Enter the number of Stocks");
                string stringNumberOfStocks = Console.ReadLine();

                if (Utility.IsNumber(stringNumberOfStocks) == false)
                {
                    Console.WriteLine("invalid Input");
                    continue;
                }

                numberOfStocks = Convert.ToInt32(stringNumberOfStocks);
                break;
            }

            ////this loops as many as number of stocks asking details form each stock.
            for (int i = 0; i < numberOfStocks; i++)
            {
                while (true)
                {
                    Console.WriteLine("Enter the Stock name");
                     stockName = Console.ReadLine();

                    if (Utility.IsNumber(stockName))
                    {
                        Console.WriteLine("No digits allowed");
                        continue;
                    }

                    if (Utility.ContainsCharacter(stockName))
                    {
                        Console.WriteLine("No characters are allowed");
                        continue;
                    }

                    break;
                }

                while (true)
                {
                    Console.WriteLine("Enter the Number Of shares");
                    string stringNumberOfShares = Console.ReadLine();

                    if (Utility.IsNumber(stringNumberOfShares) == false)
                    {
                        Console.WriteLine("invalid input");
                        continue;
                    }

                    numberOfShares = Convert.ToInt32(stringNumberOfShares);

                    break;
                }

                while (true)
                {
                    Console.WriteLine("Enter the Price Of Shares");
                    string stringPriceOfShare = Console.ReadLine();

                    if (Utility.IsNumber(stringPriceOfShare) == false)
                    {
                        Console.WriteLine("invalid input");
                        continue;
                    }

                    numberOfShares = Convert.ToInt32(stringPriceOfShare);

                    break;
                }

                StockPortfolio stockPortfolio = new StockPortfolio(stockName,numberOfShares,priceOfShares);
                stockList.Add(stockPortfolio);
            }
        }
    }
}
