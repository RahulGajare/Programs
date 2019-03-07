using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FacedDesignPatern
{
    class Program
    {
        static void StartFaced(string[] args)
        {
            CarFacade facade = new CarFacade();

            facade.CreateCompleteCar();

            Console.ReadKey();

        }
    }
}
