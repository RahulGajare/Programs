
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
