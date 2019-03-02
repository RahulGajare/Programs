// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="StockPortfolio.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.StockReport
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// StockPortfolio Class
    /// </summary>
    public class StockPortfolio
    {
        private string stockName;
        private long numberOfShares;
        private double priceOfShare;

        /// <summary>
        /// Initializes a new instance of the <see cref="StockPortfolio"/> class.
        /// </summary>
        /// <param name="stockName">Name of the stock.</param>
        /// <param name="numberOfShares">The number of shares.</param>
        /// <param name="price">The price.</param>
        public StockPortfolio(string stockName, long numberOfShares, double price)
        {
            this.stockName = stockName;
            this.numberOfShares = numberOfShares;
            this.priceOfShare = price;
        }

        /// <summary>
        /// Gets or sets the name of the stock.
        /// </summary>
        /// <value>
        /// The name of the stock.
        /// </value>
        public string StockName
        {
            get { return this.stockName; }
            set { this.stockName = value; }
        }

        /// <summary>
        /// Gets or sets the number of shares.
        /// </summary>
        /// <value>
        /// The number of shares.
        /// </value>
        public long NumberOfShares
        {
            get { return this.numberOfShares; }
            set { this.numberOfShares = value; }
        }

        /// <summary>
        /// Gets or sets the price of share.
        /// </summary>
        /// <value>
        /// The price of share.
        /// </value>
        public double PriceOfShare
        {
            get { return this.priceOfShare; }
            set { this.priceOfShare = value; }
        }
    }
}
