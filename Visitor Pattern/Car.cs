// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Car.cs" company="Bridgelabz">
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
    /// car class
    /// </summary>
    /// <seealso cref="DesignPattern.IStore" />
    public class Car : IStore
    {
        /// <summary>
        /// Gets or sets the Name of the car.
        /// </summary>
        /// <value>
        /// The Name of the car.
        /// </value>
        public string CarName { get; set; }

        /// <summary>
        /// Gets or sets the price.
        /// </summary>
        /// <value>
        /// The price.
        /// </value>
        public decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the type of the car.
        /// </summary>
        /// <value>
        /// The type of the car.
        /// </value>
        public string CarType { get; set; }

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
