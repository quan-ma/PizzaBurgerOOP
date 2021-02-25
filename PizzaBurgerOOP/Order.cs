using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaBurgerOOP
{
    public class Order
    {
        private decimal subtotal = 0;
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

        public void Total()
        {
            if (MyPizzas.Count > 0)
            {
                Console.WriteLine("\n");
                int index = 0;
                foreach (var p in MyPizzas)
                {
                    subtotal += MyPizzas[index].Price;
                    Console.WriteLine($"Pizza {index+1}, Price {MyPizzas.First().Price:C}");
                    for (int i = 0; i < p.MyPizzaToppings.Count; i++)
                    {

                        Console.WriteLine($"\tTopping {p.MyPizzaToppings[i].name}, Price {p.MyPizzaToppings[i].price:C}");
                        subtotal += p.MyPizzaToppings[i].price;
                    }
                    index++;
                }
            }

            if (MyBurgers.Count > 0)
            {
                Console.WriteLine("\n");
                int index = 0;
                foreach (var b in MyBurgers)
                {
                    Console.WriteLine($"Burger {index + 1}, Price {MyBurgers.First().Price:C}");
                    subtotal += MyBurgers[index].Price;
                    for (int i = 0; i < b.MyBurgerToppings.Count; i++)
                    {
                        Console.WriteLine($"\tTopping {b.MyBurgerToppings[i].name}, Price {b.MyBurgerToppings[i].price:C}");
                        subtotal += b.MyBurgerToppings[i].price;
                    }
                    index++;
                }
            }

            if (MyExtras.Count > 0)
            {
                Console.WriteLine("\nExtras");
                foreach(var e in MyExtras)
                {
                    if(e.Friess.Count > 0)
                    {
                        for (int i = 0; i < e.Friess.Count; i++)
                        {
                            Console.WriteLine($"Fries Size ({e.Friess[i].size}), Price {e.Friess[i].price:C}");
                            subtotal += e.Friess[i].price;
                        }
                    }

                    if(e.Drinks.Count > 0)
                    {
                        for(int i = 0; i < e.Drinks.Count; i++)
                        {
                            Console.WriteLine($"Drink Size ({e.Drinks[i].size}), Price {e.Drinks[i].price:C}");
                            subtotal += e.Drinks[i].price;
                        }
                    }
                }
            }

            Console.WriteLine($"\nYour subtotal is {subtotal:C}");
            Console.WriteLine($"5.3% sales tax: {subtotal*(5.3m/100m):C}");
            Console.WriteLine($"Total: {subtotal*(5.3m/100m) + subtotal:C}");
        }
    }
}
