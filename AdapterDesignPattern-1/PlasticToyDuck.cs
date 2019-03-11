// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPattern.AdapterDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// PlasticToyDuck class
    /// </summary>
    /// <seealso cref="DesignPattern.AdapterDesignPattern.ToyDuck" />
    public class PlasticToyDuck : ToyDuck
    {
        public void squeak()
        {
            Console.WriteLine("Squeak");
        }
    }
}
