// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteColleague2.cs" company="Bridgelabz">
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
    ///  A 'ConcreteColleague' class
    /// </summary>
    /// <seealso cref="DesignPattern.Colleague" />
    public class ConcreteColleague2 : Colleague
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConcreteColleague2"/> class.
        /// </summary>
        /// <param name="mediator">The mediator.</param>
        public ConcreteColleague2(Mediator mediator) : base(mediator)
        {
        }

        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Send(string message)
        {
            Mediator.Send(message, this);
        }

        /// <summary>
        /// Notifies the specified message.
        /// </summary>
        /// <param name="message">The message.</param>
        public void Notify(string message)
        {
            Console.WriteLine("Colleague2 gets message: " + message);
        }
    }
}