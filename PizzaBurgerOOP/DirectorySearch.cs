using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PizzaBurgerOOP
{
    public static class DirectorySearch
    {
        static string myDirectory = Directory.GetCurrentDirectory();
        static string directory = Path.GetFullPath(Path.Combine(myDirectory, "Data"));
        public static List<List<string>> fullMenuList = new List<List<string>>();
        public static List<List<string>> pizzaToppingList = new List<List<string>>();
        public static List<List<string>> burgerToppingList = new List<List<string>>();
        public static List<List<string>> extraList = new List<List<string>>();

        static DirectorySearch()
        {

        }

        public static string DisplayMenu(bool fileRead)
        {
            string menuItemsDirectory = Path.GetFullPath(Path.Combine(directory, "MenuItems.csv"));

            if(!fileRead) fullMenuList = ReadFile(fullMenuList, menuItemsDirectory);

            foreach (var fml in fullMenuList)
            {
                decimal price;
                bool success = decimal.TryParse(fml[2], out price);
                if(success)
                {
                    Console.WriteLine($"[{fml[0]}] {fml[1]} {price:C}");
                }
                else
                {
                    Console.WriteLine($"[{fml[0]}] {fml[1]}");
                }
            }
            return Console.ReadLine();
        }

        public static string DisplayPizzaToppings(bool fileRead)
        {
            var pizzaDirectory = Path.GetFullPath(Path.Combine(directory, "PizzaToppingItems.csv"));            

            if(!fileRead) pizzaToppingList = ReadFile(pizzaToppingList, pizzaDirectory);

            foreach (var ptl in pizzaToppingList)
            {
                decimal myPrice = decimal.Parse(ptl[2]);
                Console.WriteLine($"[{ptl[0]}] {ptl[1]} {myPrice:C}");
            }
            System.Console.WriteLine("[0] Done");
            return Console.ReadLine();
        }

        public static string DisplayBurgerToppings(bool fileRead)
        {
            var burgerDirectory = Path.GetFullPath(Path.Combine(directory, "BurgerToppingItems.csv"));

            if (!fileRead) burgerToppingList = ReadFile(burgerToppingList, burgerDirectory);

            foreach (var btl in burgerToppingList)
            {
                decimal myPrice = decimal.Parse(btl[2]);
                Console.WriteLine($"[{btl[0]}] {btl[1]} {myPrice:C}");
            }
            System.Console.WriteLine("[0] Done");
            return Console.ReadLine();
        }

        public static string DisplayExtras(bool fileRead)
        {
            var extraDirectory = Path.GetFullPath(Path.Combine(directory, "ExtraItems.csv"));

            if (!fileRead) extraList = ReadFile(extraList, extraDirectory);

            foreach(var el in extraList)
            {
                decimal myPrice = decimal.Parse(el[3]);
                Console.WriteLine($"[{el[0]}] {el[1]}({el[2]}) {myPrice:C}");
            }
            System.Console.WriteLine("[0] Done");
            return Console.ReadLine();
        }

        public static List<List<string>> ReadFile(List<List<string>> fml, string path)
        {
            using var reader = new StreamReader(path);
            List<string> menuList = new List<string>();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                foreach (var v in values)
                {
                    menuList.Add(v);
                }
                fml.Add(menuList.ToList());
                menuList.Clear();
            }
            return fml;

        }

        public static void InvalidInput()
        {
            System.Console.WriteLine("Invalid Input, Try Again!!");
        }
    }
}
