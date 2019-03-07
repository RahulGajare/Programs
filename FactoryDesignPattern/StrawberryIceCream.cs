using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
    class StrawberryIceCream : IiceCream
    {
        public string Functionality()
        {
            return "Strawberry Ice cream";
        }
    }
}
