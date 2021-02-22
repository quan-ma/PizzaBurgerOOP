using System;
using System.Collections.Generic;

namespace PizzaBurgerOOP
{
    public class Pizza
    {
        public List<PizzaTopping> pizzaToppings = new List<PizzaTopping>();

        public List<PizzaTopping> MyPizzaToppings { get; set; }

        public Pizza()
        {

        }

        public PizzaTopping AddPizzaTopping(string pt)
        {
            PizzaTopping pizzaTopping = new PizzaTopping();
            pizzaTopping.name = pt;
            Console.WriteLine("Returning Pizza Topping");
            return pizzaTopping;
        }


    }
}
