// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MediatorDisplay.cs" company="Bridgelabz">
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
    /// Class to display output
    /// </summary>
    public class MediatorDisplay
    {
        /// <summary>
        /// Displays this instance.
        /// </summary>
        public void Display()
        {
            ////creating object
            ConcreteMediator mediator = new ConcreteMediator();

            ////creating object of classes
            ConcreteColleague1 colleague1 = new ConcreteColleague1(mediator);
            ConcreteColleague2 colleague2 = new ConcreteColleague2(mediator);

            mediator.Colleague1 = colleague1;
            mediator.Colleague2 = colleague2;

            colleague1.Send("How are you?");
            colleague2.Send("Fine, thanks");
        }
    }
}
