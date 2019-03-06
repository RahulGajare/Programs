// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TesterClass.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPattern.Singleton_Pattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using DesignPattern.Singleton_Pattern.EagerInstantiation;

    /// <summary>
    /// TesterClass class
    /// </summary>
    public class TesterClass
    {
        /// <summary>
        /// Tests the eager instantiation.
        /// </summary>
        public static void TestEagerInstantiation()
        {
            EagerSingleton object1 = EagerSingleton.GetInstance;
            EagerSingleton object2 = EagerSingleton.GetInstance;

            Console.WriteLine("Object1 == Object2 = " + (object1 == object2));
            Console.Read();
        }
    }
}
