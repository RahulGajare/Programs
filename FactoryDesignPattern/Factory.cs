
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPattern.FactoryDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// Factory class
    /// </summary>
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
