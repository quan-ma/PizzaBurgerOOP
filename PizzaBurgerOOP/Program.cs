using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ds = PizzaBurgerOOP.DirectorySearch;

namespace PizzaBurgerOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            bool menuFile = false;
            bool pizzaFile = false;
            bool burgerFile = false;
            bool extraFile = false;

            Order o = new Order();

            while (true)
            {
                string menuSelection = ds.DisplayMenu(menuFile);
                menuFile = true;
                if (menuSelection == "0")
                    break;

                if (menuSelection == ds.fullMenuList[0][0])
                {
                    Pizza p = new Pizza();
                    while (true)
                    {
                        int pToppingSelection = Convert.ToInt32(ds.DisplayPizzaToppings(pizzaFile));
                        pizzaFile = true;
                        if (pToppingSelection == 0)
                        {
                            o.AddToOrder(p);
                            break;
                        }

                        p.AddTopping(ds.pizzaToppingList[pToppingSelection - 1][1],
                        decimal.Parse(ds.pizzaToppingList[pToppingSelection - 1][2]));
                        foreach (var pt in p.MyPizzaToppings)
                        {
                            System.Console.WriteLine($"{pt.name} {pt.price:C}");
                        }
                    }
                }

                if (menuSelection == ds.fullMenuList[1][0])
                {
                    Burger b = new Burger();
                    while (true)
                    {
                        int bToppingSelection = Convert.ToInt32(ds.DisplayBurgerToppings(burgerFile));
                        burgerFile = true;
                        if (bToppingSelection == 0)
                        {
                            o.AddToOrder(b);
                            break;
                        }

                        b.AddTopping(ds.burgerToppingList[bToppingSelection - 1][1],
                        decimal.Parse(ds.burgerToppingList[bToppingSelection - 1][2]));
                    }
                }

                if (menuSelection == ds.fullMenuList[2][0])
                {
                    while (true)
                    {
                        Extra e = new Extra();
                        int eSelection = Convert.ToInt32(ds.DisplayExtras(extraFile));
                        extraFile = true;
                        if (eSelection == 0)
                        {
                            break;
                        }

                        e.Item = ds.extraList[eSelection - 1][1];
                        e.Size = ds.extraList[eSelection - 1][2][0];
                        e.Price = decimal.Parse(ds.extraList[eSelection - 1][3]);
                        o.AddToOrder(e);
                    }
                }
            }
            o.Total();
        }
    }
}
