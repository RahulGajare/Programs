// --------------------------------------------------------------------------------------------------------------------
// <copyright file="BirdAdaptrer.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------

namespace DesignPattern.AdapterDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    class BirdAdapter : ToyDuck
    {
        // You need to implement the interface your 
        // client expects to use. 
        Bird bird;
        public BirdAdapter(Bird bird)
        {
            // we need reference to the object we 
            // are adapting 
            this.bird = bird;
        }

        public void squeak()
        {
            // translate the methods appropriately 
            bird.makeSound();
        }
    }
}
