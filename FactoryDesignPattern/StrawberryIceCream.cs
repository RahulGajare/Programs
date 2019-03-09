using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
    /// <summary>
    /// StrawberryIceCream class
    /// </summary>
    /// <seealso cref="DesignPattern.FactoryDesignPattern.IiceCream" />
    public class StrawberryIceCream : IiceCream
    {
        /// <summary>
        /// Functionalities this instance.
        /// </summary>
        /// <returns></returns>
        public string Functionality()
        {
            return "Strawberry Ice cream";
        }
    }
}
