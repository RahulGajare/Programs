using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterDesignPattern
{
    class Sparrow : Bird
    {
        // a concrete implementation of bird 
        public void fly()
        {
            Console.WriteLine("Flying");
        }
        public void makeSound()
        {
            Console.WriteLine("Chirp Chirp");
        }
    }
}
