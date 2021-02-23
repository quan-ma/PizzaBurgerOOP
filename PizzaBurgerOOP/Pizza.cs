using System;
using System.Collections.Generic;

namespace PizzaBurgerOOP
{
    public class Pizza
    {
        private List<PizzaTopping> myPizzaToppings = new List<PizzaTopping>();
        private decimal price = 10;

        public List<PizzaTopping> MyPizzaToppings { get; set; }
        public decimal Price
        {
            get
            {
                return price;
            }
        }

        public Pizza()
        {
            MyPizzaToppings = myPizzaToppings;
        }

        public void AddTopping(string _name, decimal _price)
        {
            PizzaTopping pt = new PizzaTopping()
            {
                name = _name,
                price = _price
            };

            MyPizzaToppings.Add(pt);
        }


    }
}
