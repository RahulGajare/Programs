// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Mediator.cs" company="Bridgelabz">
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
    /// The 'Mediator' abstract class
    /// </summary>
    public abstract class Mediator
   {
        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        /// <param name="colleague">The colleague.</param>
        public abstract void Send(string message, Colleague colleague);
    }
}
