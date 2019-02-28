using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OOP.StockReport
{
    class ReadJson
    {
        public static void Readjsonfile()
        {
            double totalValueOfAllStock = 0.0;
            if (File.Exists("C:\\Users\\Bridge labz\\Desktop\\Stocks.json"))
            {
                string jsonData = File.ReadAllText("C:\\Users\\Bridge labz\\Desktop\\Stocks.json");
                StockPortfolio[] jsonObjectArray = JsonConvert.DeserializeObject<StockPortfolio[]>(jsonData);

                for (int i = 0; i < jsonObjectArray.Length; i++)
                {
                    Console.WriteLine("StockName : " + jsonObjectArray[i].StockName + "\nNumber of Shares: " + jsonObjectArray[i].NumberOfShares + "\nPrice Of each share: " + jsonObjectArray[i].PriceOfShare);
                    Console.WriteLine("Total Value Of Stock " + jsonObjectArray[i].StockName + ": " + jsonObjectArray[i].NumberOfShares * jsonObjectArray[i].PriceOfShare);
                    Console.WriteLine("--------------------------------");

                    totalValueOfAllStock = totalValueOfAllStock + (jsonObjectArray[i].NumberOfShares * jsonObjectArray[i].PriceOfShare);

                }

                Console.Write("Total value Of all Stocks = " + totalValueOfAllStock);
            }
            else
            {
                Console.WriteLine("Specified file path does not exist");
                Console.Read();
            }
        }
    }
}
