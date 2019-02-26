using System;
using System.Collections.Generic;
using System.Text;

namespace OOP.InventoryDetails
{
    class InventoryDetails
    {
        private string name;
        private long weight;
        private long pricePerKG;


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public long Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public long PricePerKg
        {
            get { return this.pricePerKG; }
            set { this.pricePerKG = value; }
        }
    }
}
