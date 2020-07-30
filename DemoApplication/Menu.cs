using System;
using System.Collections.Generic;
using System.Text;

namespace DemoApplication
{
    class Menu
    {
        public static void Print(IEnumerable<IMenuItem> menuItems)
        {
            foreach (var item in menuItems)
                Console.WriteLine(item.ToMenuString());
        }
    }
}
