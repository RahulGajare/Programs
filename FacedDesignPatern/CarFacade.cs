using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FacedDesignPatern
{
    /// <summary>
    /// CarFacade Class
    /// </summary>
    public class CarFacade
    {
        CarModel model;
        CarEngine engine;
        CarBody body;
        CarAccessories accessories;

        /// <summary>
        /// Initializes a new instance of the <see cref="CarFacade"/> class.
        /// </summary>
        public CarFacade()
        {
            model = new CarModel();
            engine = new CarEngine();
            body = new CarBody();
            accessories = new CarAccessories();
        }

        /// <summary>
        /// Creates the complete car.
        /// </summary>
        public void CreateCompleteCar()
        {
            Console.WriteLine("******** Creating a Car **********\n");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();

            Console.WriteLine("\n******** Car creation complete **********");
        }
    }
}
