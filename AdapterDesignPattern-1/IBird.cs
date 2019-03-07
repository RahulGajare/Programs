using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterDesignPattern
{
   public interface Bird
    {
        // birds implement Bird interface that allows 
        // them to fly and make sounds adaptee interface 
         void fly();
         void makeSound();
    }
}
