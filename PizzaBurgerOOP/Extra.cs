using System;
using System.Collections.Generic;

namespace PizzaBurgerOOP
{
    public class Extra
    {
        private List<Fries> friess = new List<Fries>();
        private List<Drink> drinks = new List<Drink>();

        public List<Fries> Friess { get; set; }
        public List<Drink> Drinks { get; set; }

        public Extra()
        {
            Friess = friess;
            Drinks = drinks;
        }

        public void AddFries(char _size, decimal _price)
        {
            Fries f = new Fries()
            {
                size = _size,
                price = _price
            };
            Friess.Add(f);
        }

        public void AddDrink(char _size, decimal _price)
        {
            Drink d = new Drink()
            {
                size = _size,
                price = _price
            };
            Drinks.Add(d);
        }
    }
}
