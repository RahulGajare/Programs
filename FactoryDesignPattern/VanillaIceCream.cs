using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
    class VanillaIceCream : IiceCream
    {
        public string Functionality()
        {
            return "Vanilla Ice cream";
        }
    }
}
