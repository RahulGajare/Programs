// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Colleague.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator Name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------
namespace DesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// The 'Colleague' abstract class
    /// </summary>
    public abstract class Colleague
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Colleague"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        public Colleague(Mediator mediator)
        {
            this.Mediator = mediator;
        }

        /// <summary>
        /// Gets or sets the mediator.
        /// </summary>
        /// <value>
        /// The mediator.
        /// </value>
        public Mediator Mediator { get; set; }
    }
}
