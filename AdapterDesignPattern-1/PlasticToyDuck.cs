using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterDesignPattern
{
    class PlasticToyDuck : ToyDuck
    {
        public void squeak()
        {
            Console.WriteLine("Squeak");
        }
    }
}
