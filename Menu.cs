using DesignPattern.AdapterDesignPattern;
using DesignPattern.FacedDesignPatern;
using DesignPattern.FactoryDesignPattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern
{
    class Menu
    {
       

        public static void Main()
        {
            Console.WriteLine("Select from below");
            Console.WriteLine("1) Adapter Design Pattern");
            Console.WriteLine("2) Faced Design pattern");
            Console.WriteLine("3) Factory Design pattern");
            Console.WriteLine("4) Observer Pattern");
            Console.WriteLine("5) Proxy Design Pattern");

            int option = Console.Read();

            switch (option)
            {
                case 1:
                    {
                        StartAdapter.Startadapter();
                        break;
                    }

                case 2:
                    {
                        StartFaced.Startfaced();
                        break;
                    }

                case 3:
                    {
                        StartFactory.Get();
                        break;
                    }

                case 4:
                    {
                        break;
                    }

                case 5:
                    {
                        break;
                    }

            }
        }
    }
}
