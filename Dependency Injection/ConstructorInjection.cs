// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConstructorInjection.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------
namespace Implementations
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// to demonstrate constructor injection
    /// </summary>
    public class ConstructorInjection
    {
        /// <summary>
        /// The text
        /// </summary>
        private IText text;

        /// <summary>
        /// Initializes a new instance of the <see cref="ConstructorInjection"/> class.
        /// </summary>
        /// <param name="text1">The text1.</param>
        public ConstructorInjection(IText text1)
        {
            this.text = text1;
        }

        /// <summary>
        /// Prints this instance.
        /// </summary>
        public void Print()
        {
            this.text.Print();
        }
    }
}
