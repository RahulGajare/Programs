// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Wheat.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// -----------------------------------------------------------------------------------------------------------------------------

namespace OOP.InventoryManagementProgram
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Wheat class
    /// </summary>
    public class Wheat
    {
        /// <summary>
        /// The name/
        /// </summary>
        private string name;

        /// <summary>
        /// The weight
        /// </summary>
        private double weight;

        /// <summary>
        /// The price per kg
        /// </summary>
        private double pricePerKG;


        public Wheat(string name, double weight, double pricePerKG)
        {
            this.name = name;
            this.weight = weight;
            this.pricePerKG = pricePerKG;
        }
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
        public double Weight
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

        public static void CreateWheatObject(string name, double weight, double pricePerKG)
        {
            Wheat wheat = new Wheat(name, weight, pricePerKG);
            InventoryTypes inventoryType = new InventoryTypes();
            inventoryType.InventoryTypesObject.WheatList.Add(wheat);

        }
    }
}
