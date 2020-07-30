using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoApplication
{
    class Program
    {
        static List<Drink> Drinks = new List<Drink>();
        static List<Beaverage> Beaverages = new List<Beaverage>();
        static Dictionary<ICartItem, int> Cart = new Dictionary<ICartItem, int>();

        static void Main(string[] args)
        {
            Drinks.Add(new Drink("Coke", 4.5m));
            Drinks.Add(new Drink("Fanta", 4m));
            Beaverages.Add(new Beaverage("Snack", 5.5m));
            Beaverages.Add(new Beaverage("Sandwich", 6m));

            Console.WriteLine("Hello! Welcome to Grocery Store!\n");
            PrintMenu();

            Cart.Add(Drinks[0], 2);
            Cart.Add(Beaverages[1], 1);
            PrintCart();
        }

        static void PrintCart()
        {
            Console.WriteLine("*** Cart ***");

            foreach (var item in Cart)
            {
                Console.WriteLine($"{item.Key.Name}\t${item.Key.Price}\t{item.Value}pcs");
            }
        }

        static void PrintMenu()
        {
            Console.WriteLine("*** Menu ***");
            var products = new List<IMenuItem>();

            products.AddRange(Beaverages);
            products.AddRange(Drinks);

            Menu.Print(products);
        }
    }
}
