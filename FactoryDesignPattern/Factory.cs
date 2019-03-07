using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
    static class Factory
    {
        /// <summary>
        /// This is the Factory method
        /// </summary>
        public static IiceCream Get(int id)
        {

            switch (id)
            {
                case 0:
                    return new ChocolateIceCream();
                case 1:
                    return new VanillaIceCream();
                case 2:
                    return new StrawberryIceCream();
                default:
                    return null;
            }
        }
    }
}
