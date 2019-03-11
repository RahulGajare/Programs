// --------------------------------------------------------------------------------------------------------------------
// <copyright file="VisitorPattern.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Rahul Gajarer"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Main class for visitor pattern
    /// </summary>
    public class VisitorPattern
    {
        /// <summary>
        /// main method of visitor pattern class
        /// </summary>
        public void Visitor()
        {
            ////creating object
            List<IStore> store = new List<IStore>();
            ////adding values
            store.Add(new Car() { CarName = "A1", Price = 200M, CarType = "Mercedes" });
            store.Add(new Car() { CarName = "A2", Price = 100M, CarType = "Normal" });

            ////adding values
            store.Add(new Bikes() { BikeName = "B1", Price = 50M, BikeType = "Bullet" });
            store.Add(new Bikes() { BikeName = "B2", Price = 30M, BikeType = "Normal" });

            ////Show price of each item
            PriceVisitor priceVisitor = new PriceVisitor();
            foreach (var element in store)
            {
                element.Visit(priceVisitor);
            }

            ////Show weight of each item
            WeightVisitor weightVisitor = new WeightVisitor();
            foreach (var element in store)
            {
                element.Visit(weightVisitor);
            }
        }
    }
}
