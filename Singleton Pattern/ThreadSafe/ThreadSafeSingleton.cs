// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ThreadSafeSingleton.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPattern.Singleton_Pattern.ThreadSafe
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// ThreadSafeSingleton class
    /// </summary>
    public class ThreadSafeSingleton
    {
        /// <summary>
        /// The instance
        /// </summary>
        private static ThreadSafeSingleton instance = null;
     
        /// <summary>
        /// The lock this
        /// </summary>
        private static object lockThis = new object();

        /// <summary>
        /// Prevents a default instance of the <see cref="ThreadSafeSingleton"/> class from being created.
        /// </summary>
        private ThreadSafeSingleton()
        {
        }

        /// <summary>
        /// Gets the get instance.
        /// </summary>
        /// <value>
        /// The get instance.
        /// </value>
        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                lock (lockThis)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                       
                    return instance;
                }
            }
        }
    }
}
