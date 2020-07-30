using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApplication
{
    class Drink: IMenuItem, ICartItem
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Drink(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string ToMenuString()
        {
            return $"{Name}\t${Price} per 1l";
        }
    }
}
