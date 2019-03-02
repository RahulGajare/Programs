// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Rice.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.InventoryDetails
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Rice Class
    /// </summary>
    public class Rice
    {
        /// <summary>
        /// The name
        /// </summary>
        private string name;

        /// <summary>
        /// The weight
        /// </summary>
        private long weight;

        /// <summary>
        /// The price per kg
        /// </summary>
        private double pricePerKG;

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Gets or sets the weight.
        /// </summary>
        /// <value>
        /// The weight.
        /// </value>
        public long Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        /// <summary>
        /// Gets or sets the price per kg.
        /// </summary>
        /// <value>
        /// The price per kg.
        /// </value>
        public double PricePerKg
        {
            get { return this.pricePerKG; }
            set { this.pricePerKG = value; }
        }
    }
}
