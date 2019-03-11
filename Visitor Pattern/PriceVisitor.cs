// --------------------------------------------------------------------------------------------------------------------
// <copyright file="PriceVisitor.cs" company="Bridgelabz">
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
    /// price visitor class
    /// </summary>
    /// <seealso cref="DesignPattern.IVisitor" />
    public class PriceVisitor : IVisitor
    {
        /// <summary>
        /// The car discount
        /// </summary>
        private const int CarDiscount = 5;

        /// <summary>
        /// The bike discount
        /// </summary>
        private const int BikeDiscount = 2;

        /// <summary>
        /// Accepts the specified car.
        /// </summary>
        /// <param name="car">The car.</param>
        public void Accept(Car car)
        {
            decimal carPriceAfterDicount = car.Price - ((car.Price / 100) * CarDiscount);
            Console.WriteLine("Car {0} price: {1}", car.CarName, carPriceAfterDicount);
        }

        /// <summary>
        /// Accepts the specified bike.
        /// </summary>
        /// <param name="bike">The bike.</param>
        public void Accept(Bikes bike)
        {
            decimal bikePriceAfterDicount = bike.Price - ((bike.Price / 100) * BikeDiscount);
            Console.WriteLine("Bike {0} price: {1}", bike.BikeName, bikePriceAfterDicount);
        }
    }
}
