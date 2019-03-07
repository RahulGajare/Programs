using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
    class ChocolateIceCream : IiceCream
    {
        public string Functionality()
        {
            return "Chocolate Ice cream";
        }
    }
}
