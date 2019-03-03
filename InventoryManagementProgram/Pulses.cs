// -------------------------------------------------------------------------------------------------------------------------
// <copyright file="Pulses.cs" company="Bridgelabz">
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
    /// pulses Class
    /// </summary>
    public class Pulses
    {
        private string name;
        private double weight;
        private double pricePerKG;

        public Pulses(string name, double weight, double pricePerKG)
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

        public static void CreatePulsesObject(string name, double weight, double pricePerKG)
        {
            Pulses pulse = new Pulses(name, weight, pricePerKG);
            InventoryTypes inventoryType = new InventoryTypes();
            inventoryType.InventoryTypesObject.PulsesList.Add(pulse);

        }
    }
}
