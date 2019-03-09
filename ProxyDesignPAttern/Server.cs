using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ProxyDesignPAttern
{
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
