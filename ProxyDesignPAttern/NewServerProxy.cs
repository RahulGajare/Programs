using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ProxyDesignPAttern
{
    class NewServerProxy : IServer
    {
        /// <summary>
        /// The order
        /// </summary>
        private string Order;

        /// <summary>
        /// The server
        /// </summary>
        private Server _server = new Server();

        /// <summary>
        /// Takes the order.
        /// </summary>
        /// <param name="order">The order.</param>
        public void TakeOrder(string order)
        {
            Console.WriteLine("New trainee server takes order for " + order + ".");
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
            Console.WriteLine("New trainee cannot process payments yet!");
            _server.ProcessPayment(payment);
        }
    }
}
