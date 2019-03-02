// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Data.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.Commercial_Data_Processing
{
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Text;

    /// <summary>
    /// Data Class
    /// </summary>
    public class DataLogic
    {
        /// <summary>
        /// Reads from file.
        /// </summary>
        /// <returns>List of CompanyShares</returns>
        public static List<CompanyShares> ReadFromFile()
        {
            SinglyLinkedList<CompanyShares> companysharesLinkedList = new SinglyLinkedList<CompanyShares>();
            if (File.Exists("C:\\Users\\Bridge labz\\Desktop\\Commersial\\CompanyShares.json"))
            {
                string jsonData = File.ReadAllText("C:\\Users\\Bridge labz\\Desktop\\Commersial\\CompanyShares.json");
                List<CompanyShares> jsonObjectArray = JsonConvert.DeserializeObject<List<CompanyShares>>(jsonData);

                foreach (CompanyShares cs in jsonObjectArray)
                {
                    companysharesLinkedList.Add(cs);
                }
                return jsonObjectArray;
            }
            else
            {
                Console.WriteLine("Specified file path does not exist");
                return new List<CompanyShares>();
            }
        }

        /// <summary>
        /// Writes to file.
        /// </summary>
        /// <param name="companySharesList">The company shares list.</param>
        public static void WriteToFile(List<CompanyShares> companySharesList)
        {
            string jsonData = JsonConvert.SerializeObject(companySharesList);

            
            System.IO.File.WriteAllText("C:\\Users\\Bridge labz\\Desktop\\Commersial\\CompanyShares.json", jsonData);
        }

        public static Stack ReadStockSymbols()
        {
            Stack symbolStack = new Stack();
            symbolStack.StackInitialise(1000);
            List<CompanyShares> stocksList = ReadFromFile();

            foreach (CompanyShares companyShares in stocksList)
            {
                symbolStack.Push(companyShares.Symbol);               
            }

            return symbolStack;
        }

        public static void WriteSymbol(Stack symbolStack)
        {
            List<string> symbolList = new List<string>(); 
            while (!symbolStack.IsEmpty())
            {
                symbolList.Add(symbolStack.Pop());
                
            }
            string jsonData = JsonConvert.SerializeObject(symbolList);

            
            System.IO.File.WriteAllText("C:\\Users\\Bridge labz\\Desktop\\Commersial\\SymbolPurchased.json", jsonData);
        }
    }
}
