using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.ProxyDesignPAttern
{
    public interface IServer
    {
        void TakeOrder(string order);
        string DeliverOrder();
        void ProcessPayment(string payment);
    }
}
