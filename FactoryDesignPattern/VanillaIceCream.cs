using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
    /// <summary>
    /// VanillaIceCream class
    /// </summary>
    /// <seealso cref="DesignPattern.FactoryDesignPattern.IiceCream" />
    public class VanillaIceCream : IiceCream
    {
        /// <summary>
        /// Functionalities this instance.
        /// </summary>
        /// <returns></returns>
        public string Functionality()
        {
            return "Vanilla Ice cream";
        }
    }
}
