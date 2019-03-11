
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPattern.FacedDesignPatern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary> 
    /// Program class
    /// </summary>
    public class StartFaced
    {
        /// <summary>
        /// Starts the faced.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public static void Startfaced()
        {
            CarFacade facade = new CarFacade();

            facade.CreateCompleteCar();

            Console.ReadKey();

        }
    }
}
