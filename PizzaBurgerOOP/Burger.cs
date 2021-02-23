using System;
using System.Collections.Generic;

namespace PizzaBurgerOOP
{
    public class Burger
    {
        private decimal price = 7;
        private List<BurgerTopping> myBurgerToppings = new List<BurgerTopping>();
        public List<BurgerTopping> MyBurgerToppings { get; set; }

        public decimal Price
        {
            get
            {
                return price;
            }
        }

        public Burger()
        {
            MyBurgerToppings = myBurgerToppings;
        }

        public void AddTopping(string _name, decimal _price)
        {
            BurgerTopping bt = new BurgerTopping()
            {
                name = _name,
                price = _price
            };

            MyBurgerToppings.Add(bt);
        }
    }
}
