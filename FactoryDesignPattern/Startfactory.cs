﻿
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

    public class StartFactory
    {
        /// <summary>
        /// Gets this instance.
        /// </summary>
        /// <returns></returns>
        public static IiceCream Get()
        {
            Console.WriteLine("Press 1) for ChocolateIceCream");
            Console.WriteLine("Press 2) for VanillaIceCream");
            Console.WriteLine("Press 3) for StrawberryIceCream");
             int id =Convert.ToInt32(Console.ReadLine());

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
