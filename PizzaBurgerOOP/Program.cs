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
                int intVal;
                string menuSelection = ds.DisplayMenu(menuFile);
                menuFile = true;
                bool isMsValid = int.TryParse(menuSelection, out intVal);
                if (isMsValid && intVal < ds.fullMenuList.Count && intVal >= 0)
                {
                    if (menuSelection == "0")
                        break;

                    if (menuSelection == ds.fullMenuList[0][0])
                    {
                        Pizza p = new Pizza();
                        while (true)
                        {
                            int pVal;
                            string pToppingSelection = ds.DisplayPizzaToppings(pizzaFile);
                            pizzaFile = true;
                            bool isPtValid = int.TryParse(pToppingSelection, out pVal);
                            if (isPtValid && pVal <= ds.pizzaToppingList.Count && pVal >= 0)
                            {
                                if (pVal == 0)
                                {
                                    o.AddToOrder(p);
                                    break;
                                }

                                p.AddTopping(ds.pizzaToppingList[pVal - 1][1],
                                decimal.Parse(ds.pizzaToppingList[pVal - 1][2]));
                                foreach (var pt in p.MyPizzaToppings)
                                {
                                    Console.WriteLine($"{pt.name} {pt.price:C}");
                                }
                            }
                            else
                            {
                                ds.InvalidInput();
                            }
                        }
                    }

                    if (menuSelection == ds.fullMenuList[1][0])
                    {
                        Burger b = new Burger();
                        while (true)
                        {
                            int bVal;
                            string bToppingSelection = ds.DisplayBurgerToppings(burgerFile);
                            burgerFile = true;
                            bool isBtValid = int.TryParse(bToppingSelection, out bVal);
                            if (isBtValid && bVal <= ds.burgerToppingList.Count && bVal >= 0)
                            {
                                if (bVal == 0)
                                {
                                    o.AddToOrder(b);
                                    break;
                                }

                                b.AddTopping(ds.burgerToppingList[bVal - 1][1],
                                decimal.Parse(ds.burgerToppingList[bVal - 1][2]));
                                foreach (var bt in b.MyBurgerToppings)
                                {
                                    Console.WriteLine($"{bt.name} {bt.price:C}");
                                }
                            }
                            else
                            {
                                ds.InvalidInput();
                            }
                        }
                    }

                    if (menuSelection == ds.fullMenuList[2][0])
                    {
                        while (true)
                        {
                            int eVal;
                            Extra e = new Extra();
                            string eSelection = ds.DisplayExtras(extraFile);
                            extraFile = true;
                            bool isExValid = int.TryParse(eSelection, out eVal);
                            if (isExValid && eVal <= ds.extraList.Count && eVal >= 0)
                            {
                                if (eVal == 0)
                                {
                                    break;
                                }

                                e.Item = ds.extraList[eVal - 1][1];
                                e.Size = ds.extraList[eVal - 1][2][0];
                                e.Price = decimal.Parse(ds.extraList[eVal - 1][3]);
                                o.AddToOrder(e);

                            }
                            else
                            {
                                ds.InvalidInput();
                            }

                        }
                    }
                }
                else
                {
                    ds.InvalidInput();
                }

            }
            o.Total();
        }
    }
}
