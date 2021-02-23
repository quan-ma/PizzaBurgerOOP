using System;
using System.Collections.Generic;

namespace PizzaBurgerOOP
{
    public class Order
    {
        private List<Burger> myBurgers = new List<Burger>();
        private List<Pizza> myPizzas = new List<Pizza>();
        private List<Extra> myExtras = new List<Extra>();

        public List<Burger> MyBurgers { get; set; }
        public List<Pizza> MyPizzas { get; set; }
        public List<Extra> MyExtras { get; set; }

        public Order()
        {
            MyBurgers = myBurgers;
            MyPizzas = myPizzas;
            MyExtras = myExtras;
        }

        public void AddToOrder(Pizza _pizza)
        {
            myPizzas.Add(_pizza);
        }

        public void AddToOrder(Burger _burger)
        {
            myBurgers.Add(_burger);
        }

        public void AddToOrder(Extra _extra)
        {
            myExtras.Add(_extra);
        }
    }
}
