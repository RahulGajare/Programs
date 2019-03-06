// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TesterClass.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPattern.Singleton_Pattern.LazyInstantiation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// TesterClass class
    /// </summary>
    public class TesterClass
    {
        /// <summary>
        /// Tests the lazy instantiation.
        /// </summary>
        public static void TestLazyInstantiation()
        {
            LazySingleton object1 = LazySingleton.GetInstance;
            LazySingleton object2 = LazySingleton.GetInstance;

            Console.WriteLine("Object1 == Object2 = " + (object1 == object2));
            Console.Read();
        }
    }
}
