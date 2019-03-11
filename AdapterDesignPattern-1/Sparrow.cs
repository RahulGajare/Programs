// --------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPattern.AdapterDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class Sparrow : Bird
    {
        //// a concrete implementation of bird 
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
