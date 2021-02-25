﻿using System;
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

                int menuSelection = Convert.ToInt32(ds.DisplayMenu(menuFile));
                if (menuSelection == 0)
                    break;

                if(menuSelection.ToString() == ds.fullMenuList[0][0])
                {
                    Pizza p = new Pizza();
                    while (true)
                    {
                        int pToppingSelection = Convert.ToInt32(ds.DisplayPizzaToppings(pizzaFile));
                        if (pToppingSelection == 0)
                        {
                            o.AddToOrder(p);
                            break;
                        }
                            
                        p.AddTopping(ds.pizzaToppingList[pToppingSelection - 1][1], decimal.Parse(ds.pizzaToppingList[pToppingSelection - 1][2]));
                        pizzaFile = true;
                    }
                }
                menuFile = true;

                if(menuSelection.ToString()== ds.fullMenuList[1][0])
                {
                    Burger b = new Burger();
                    while(true)
                    {
                        int bToppingSelection = Convert.ToInt32(ds.DisplayBurgerToppings(burgerFile));
                        if (bToppingSelection == 0)
                        {
                            o.AddToOrder(b);
                            break;
                        }

                        b.AddTopping(ds.burgerToppingList[bToppingSelection - 1][1], decimal.Parse(ds.burgerToppingList[bToppingSelection - 1][2]));
                        burgerFile = true;
                    }
                }

            }

            o.Total();
        }
    }
}
