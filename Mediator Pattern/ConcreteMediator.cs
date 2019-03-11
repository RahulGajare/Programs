// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ConcreteMediator.cs" company="Bridgelabz">
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
    /// The 'ConcreteMediator' class
    /// </summary>
    /// <seealso cref="DesignPattern.Mediator" />
    public class ConcreteMediator : Mediator
    {
        /// <summary>
        /// The colleague1
        /// </summary>
        private ConcreteColleague1 colleague1;

        /// <summary>
        /// The colleague2
        /// </summary>
        private ConcreteColleague2 colleague2;

        /// <summary>
        /// Sets the colleague1.
        /// </summary>
        /// <value>
        /// The colleague1.
        /// </value>
        public ConcreteColleague1 Colleague1
        {
            set { this.colleague1 = value; }
        }

        /// <summary>
        /// Sets the colleague2.
        /// </summary>
        /// <value>
        /// The colleague2.
        /// </value>
        public ConcreteColleague2 Colleague2
        {
            set { this.colleague2 = value; }
        }

        /// <summary>
        /// Sends the specified message.
        /// </summary>
        /// <param name="message">The message</param>
        /// <param name="colleague">The colleague</param>
        public override void Send(string message, Colleague colleague)
        {
            if (colleague == this.colleague1)
            {
                this.colleague2.Notify(message);
            }
            else
            {
                this.colleague1.Notify(message);
            }
        }
    }
}
