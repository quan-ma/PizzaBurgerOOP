using System;
using System.Collections.Generic;

namespace PizzaBurgerOOP
{
    public class Order
    {
        public List<Burger> MyBurgers { get; set; }
        public List<Pizza> MyPizzas { get; set; }
        public List<Extra> MyExtras { get; set; }

        public Order()
        {

        }
    }
}
