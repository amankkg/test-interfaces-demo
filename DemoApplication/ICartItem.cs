using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApplication
{
    interface ICartItem
    {
        string Name { get; }
        decimal Price { get; }
    }
}
