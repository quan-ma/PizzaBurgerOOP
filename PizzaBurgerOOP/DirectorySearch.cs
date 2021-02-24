using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PizzaBurgerOOP
{
    public static class DirectorySearch
    {
        static string directory = Directory.GetCurrentDirectory();
        

        public static void DisplayMenu()
        {
            string menuItemsDirectory = Path.GetFullPath(Path.Combine(directory, "..", "..", "..", "Data", "MenuItems.csv"));
            List<List<string>> fullMenuList = new List<List<string>>();

            fullMenuList = ReadFile(fullMenuList, menuItemsDirectory);

            foreach (var fml in fullMenuList)
            {
                Console.WriteLine($"{fml[0]} {fml[1]}");
            }
        }

        public static void DisplayPizzaToppings()
        {
            var pizzaDirectory = Path.GetFullPath(Path.Combine(directory, "..", "..", "..", "Data", "PizzaToppingItems.csv"));

            List<List<string>> pizzaToppingList = new List<List<string>>();

            pizzaToppingList = ReadFile(pizzaToppingList, pizzaDirectory);

            foreach (var ptl in pizzaToppingList)
            {
                decimal myPrice = decimal.Parse(ptl[2]);
                Console.WriteLine($"{ptl[0]} {ptl[1]} {myPrice:C}");
            }
        }

        public static List<List<string>> ReadFile(List<List<string>> fml, string path)
        {
            using (var reader = new StreamReader(path))
            {
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
        }
    }
}
