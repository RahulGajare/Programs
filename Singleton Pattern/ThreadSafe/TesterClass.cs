// --------------------------------------------------------------------------------------------------------------------
// <copyright file="TesterClass.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPattern.Singleton_Pattern.ThreadSafe
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using DesignPattern.Singleton_Pattern.ThreadSafe;
   
    /// <summary>
    /// TesterClass class
    /// </summary>
    public class TesterClass
    {
        /// <summary>
        /// Tests the thread safe singleton.
        /// </summary>
        public static void TestThreadSafeSingleton()
        {
            ThreadSafeSingleton object1 = ThreadSafeSingleton.GetInstance;
            ThreadSafeSingleton object2 = ThreadSafeSingleton.GetInstance;

            Console.WriteLine("Object1 == Object2 = " + (object1 == object2));
            Console.Read();
        }
    }
}
