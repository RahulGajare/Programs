using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Commercial_Data_Processing
{
    interface IStockAccount
    {
        void Stockaccount(string fileName);
        double ValueOf();
        void Buy(long numberOfShares, double price ,string symbol);
        void Sell(string symbol);
        void Save(string fileName);
        void printReport();

    }
}
