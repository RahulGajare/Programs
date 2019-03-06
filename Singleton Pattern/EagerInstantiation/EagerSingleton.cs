// --------------------------------------------------------------------------------------------------------------------
// <copyright file="EagerSingleton.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern.Singleton_Pattern.EagerInstantiation
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// EagerSingleton class
    /// </summary>
    public class EagerSingleton
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static EagerSingleton instance = new EagerSingleton();

        /// <summary>
        /// Prevents a default instance of the <see cref="EagerSingleton"/> class from being created.
        /// </summary>
        private EagerSingleton()
        {
        }

        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        public static EagerSingleton GetInstance
        {
            get
            {
                return instance;
            }
        }
    }
}
