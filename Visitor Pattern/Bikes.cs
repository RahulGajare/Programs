// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Bikes.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Bike class
    /// </summary>
    /// <seealso cref="DesignPattern.IStore" />
    public class Bikes : IStore
    {
        /// <summary>
        /// Gets or sets the Name of the bike.
        /// </summary>
        /// <value>
        /// The Name of the bike.
        /// </value>
        public string BikeName { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the type of the bike.
        /// </summary>
        /// <value>
        /// The type of the bike.
        /// </value>
        public string BikeType { get; set; }

        /// <summary>
        /// Visits the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor</param>
        public void Visit(IVisitor visitor)
        {
            visitor.Accept(this);
        }
    }
}
