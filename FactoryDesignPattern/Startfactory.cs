using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.FactoryDesignPattern
{
    class StartFactory
    {
        public static IiceCream Get()
        {
            Console.WriteLine("Press 1) for ChocolateIceCream");
            Console.WriteLine("Press 2) for VanillaIceCream");
            Console.WriteLine("Press 3) for StrawberryIceCream");
             int id =Convert.ToInt32(Console.ReadLine());

            switch (id)
            {
                case 0:
                    return new ChocolateIceCream();
                case 1:
                    return new VanillaIceCream();
                case 2:
                    return new StrawberryIceCream();
                default:
                    return null;
            }
        }
    }
}
