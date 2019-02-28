using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.Commercial_Data_Processing
{
    class CompanyShares
    {
       
        private long numberOfShares;
        private double priceOfShare;
        private string symbol;
        private string datetime;


        public CompanyShares(long numberOfShares, double price ,string symbol , string datetime)
        {
           
            this.numberOfShares = numberOfShares;
            this.priceOfShare = price;
            this.symbol = symbol;
            this.datetime = datetime;
        }

       

        public long NumberOfShares
        {
            get { return this.numberOfShares; }
            set { this.numberOfShares = value; }
        }

        public double PriceOfShare
        {
            get { return this.priceOfShare; }
            set { this.priceOfShare = value; }
        }

        public string Symbol
        {
            get { return this.symbol; }
            set { this.symbol = value; }
        }

        public string DateTime
        {
            get { return this.datetime; }
            set { this.datetime = value; }
        }

    }
}
