// --------------------------------------------------------------------------------------------------------------------
// <copyright file="WeightVisitor.cs" company="Bridgelabz">
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
    /// Weight visitor class
    /// </summary>
    /// <seealso cref="DesignPattern.IVisitor" />
    public class WeightVisitor : IVisitor
    {
        /// <summary>
        /// Accepts the specified car.
        /// </summary>
        /// <param name="car">The car.</param>
        public void Accept(Car car)
        {
            switch (car.CarType)
            {
                case "Mercedes":
                    Console.WriteLine("Car {0} weight: {1} KG", car.CarName, 1750);
                    break;
                case "Normal":
                    Console.WriteLine("Car {0} weight: {1} KG", car.CarName, 750);
                    break;
            }
        }

        /// <summary>
        /// Accepts the specified bike.
        /// </summary>
        /// <param name="bike">The bike.</param>
        public void Accept(Bikes bike)
        {
            switch (bike.BikeType)
            {
                case "Bullet":
                    Console.WriteLine("Bike {0} weight: {1} KG", bike.BikeName, 300);
                    break;
                case "Normal":
                    Console.WriteLine("Bike {0} weight: {1} KG", bike.BikeName, 100);
                    break;
            }
        }
    }
}
