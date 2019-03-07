using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.AdapterDesignPattern
{
    public interface ToyDuck
    {
        // target interface 
        // toyducks dont fly they just make 
        // squeaking sound 
         void squeak();
    }
}
