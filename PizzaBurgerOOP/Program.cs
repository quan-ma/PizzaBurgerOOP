using System;
using System.Collections.Generic;

namespace PizzaBurgerOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose PizzaTopping");
            Pizza p = new Pizza();
            p.AddTopping("Mushroom", .5m);
            p.AddTopping("Skittles", 1.5m);
            Pizza p2 = new Pizza();
            p2.AddTopping("ExtraCheese", 5m);
            Burger b = new Burger();
            b.AddTopping("Cheese", 1m);
            Extra e = new Extra();
            e.AddDrink('S', 1m);
            e.AddFries('L', 3m);
            Order o = new Order();
            o.AddToOrder(p);
            o.AddToOrder(p2);
            o.AddToOrder(b);
            o.AddToOrder(e);
            o.Total();
        }
    }
}
