
// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------


namespace DesignPattern.ProxyDesignPAttern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Server : IServer
    {
        private string Order;

        /// <summary>
        /// Takes the order.
        /// </summary>
        /// <param name="order">The order.</param>
        public void TakeOrder(string order)
        {
            Console.WriteLine("Server takes order for " + order + ".");
            Order = order;
        }

        /// <summary>
        /// Delivers the order.
        /// </summary>
        /// <returns></returns>
        public string DeliverOrder()
        {
            return Order;
        }

        /// <summary>
        /// Processes the payment.
        /// </summary>
        /// <param name="payment">The payment.</param>
        public void ProcessPayment(string payment)
        {
            Console.WriteLine("Payment for order (" + payment + ") processed.");
        }
    }
}
