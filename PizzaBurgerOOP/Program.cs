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
            p.AddTopping("Mushroom", .01m);
            p.AddTopping("Skittles", 5.5m);
            Order o = new Order();
            o.AddToOrder(p);
        }
    }
}
