using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.StockReport
{
    class StockPortfolio
    {
        private string stockName;
        private long numberOfShares;
        private double price;

        public StockPortfolio(string stockName, long numberOfShares, double price)
        {
            this.stockName = stockName;
            this.numberOfShares = numberOfShares;
            this.price = price;
        }

        public string StockName
        {
            get { return this.stockName; }
            set { this.stockName = value; }
        }

        public long NumberOfShares
        {
            get { return this.numberOfShares; }
            set { this.numberOfShares = value; }
        }

        public double Price
        {
            get { return this.price; }
            set { this.price = value; }
        }

    }
}
