using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Commercial_Data_Processing
{
    class StockAccount : IStockAccount
    {
        SinglyLinkedList<CompanyShares> companySharesList= new SinglyLinkedList<CompanyShares>();


        public void Buy(long numberOfShares, double price, string symbol)
        {
            List<CompanyShares> companySharesList = Data.ReadFromFile();

            foreach (CompanyShares shares in companySharesList)
            {
                if (shares.Symbol.Equals(symbol))
                {
                    Console.WriteLine("You have already bought this share with symbol "+ symbol);
                    return;
                }
            }
            string dateTime = DateTime.Now.ToString();
            CompanyShares companyShares = new CompanyShares(numberOfShares, price, symbol,dateTime);
            companySharesList.Add(companyShares);

            Data.WriteToFile(companySharesList);

        }

        public void printReport()
        {
            throw new NotImplementedException();
        }

        public void Save(string fileName)
        {
            throw new NotImplementedException();
        }

        public void Sell(string symbol)
        {
            List<CompanyShares> companySharesList = Data.ReadFromFile();
            foreach (CompanyShares companyShares in companySharesList)
            {
                if (companyShares.Symbol.Equals(symbol))
                {
                    companySharesList.Remove(companyShares);
                    Console.WriteLine("Share with Symbol " + symbol + "removed" );
                    Data.WriteToFile(companySharesList);
                    return;
                }
            }

            Console.WriteLine("stock with Symbol " + symbol + "does not exist");


                
        }

        public double ValueOf()
        {
            throw new NotImplementedException();
        }

        void Stockaccount(string fileName)
        {
            throw new NotImplementedException();
        }

        void IStockAccount.Stockaccount(string fileName)
        {
            throw new NotImplementedException();
        }
    }
}
