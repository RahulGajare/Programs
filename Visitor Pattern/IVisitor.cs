// --------------------------------------------------------------------------------------------------------------------
// <copyright file="IVisitor.cs" company="Bridgelabz">
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
    /// visitor interface
    /// </summary>
    public interface IVisitor
    {
        /// <summary>
        /// Accepts the specified car.
        /// </summary>
        /// <param name="car">The car.</param>
        void Accept(Car car);

        /// <summary>
        /// Accepts the specified bike.
        /// </summary>
        /// <param name="bike">The bike.</param>
        void Accept(Bikes bike);
    }
}
