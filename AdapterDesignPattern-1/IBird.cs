// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StartAdapter.cs" company="Bridgelabz">
//   Copyright © 2018 Company
// </copyright>
// <creator name="Rahul Gajare"/>
// --------------------------------------------------------------------------------------------------------------------


namespace DesignPattern.AdapterDesignPattern
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public interface Bird
    {
        // birds implement Bird interface that allows 
        // them to fly and make sounds adaptee interface 
         void fly();
         void makeSound();
    }
}
