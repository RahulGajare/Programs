using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
    /// <summary>
    /// ChocolateIceCream class
    /// </summary>
    /// <seealso cref="DesignPattern.FactoryDesignPattern.IiceCream" />
    public class ChocolateIceCream : IiceCream
    {
        /// <summary>
        /// Functionalities this instance.
        /// </summary>
        /// <returns></returns>
        public string Functionality()
        {
            return "Chocolate Ice cream";
        }
    }
}
