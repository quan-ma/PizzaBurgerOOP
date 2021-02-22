using System;
using System.Collections.Generic;

namespace PizzaBurgerOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose PizzaTopping");
            string input = Console.ReadLine();
            Pizza pizza = new Pizza();
            Pizza myPizza = new Pizza();
            PizzaTopping myPizzaTopping1 = pizza.AddPizzaTopping("Sausage");
            PizzaTopping myPizzaTopping2 = pizza.AddPizzaTopping("Tomatoes");
            myPizza.MyPizzaToppings.Add(myPizzaTopping1);
            myPizza.MyPizzaToppings.Add(myPizzaTopping2);

            foreach (var p in pizza.MyPizzaToppings)
            {
                Console.WriteLine(p.name);
            }
        }
    }
}
