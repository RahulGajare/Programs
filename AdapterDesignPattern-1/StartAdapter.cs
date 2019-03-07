using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterDesignPattern
{
    class StartAdapter
    {
        public static void Startadapter()
        {
            Sparrow sparrow = new Sparrow();
            ToyDuck toyDuck = new PlasticToyDuck();

            // Wrap a bird in a birdAdapter so that it  
            // behaves like toy duck 
            ToyDuck birdAdapter = new BirdAdapter(sparrow);

            Console.WriteLine("Sparrow...");
            sparrow.fly();
            sparrow.makeSound();

            Console.WriteLine("ToyDuck...");
            toyDuck.squeak();

            // toy duck behaving like a bird  
            Console.WriteLine("BirdAdapter...");
            birdAdapter.squeak();
            Console.ReadLine();
        }
    }
}
