using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApplication
{
    class Beaverage : IMenuItem, ICartItem
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Beaverage(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string ToMenuString()
        {
            return $"{Name}\t${Price}/pcs";
        }
    }
}
