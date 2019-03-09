using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FacedDesignPatern
{
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
