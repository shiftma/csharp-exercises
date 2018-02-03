using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Menu
    {
        public List<MenuItem> menuItems = new List<MenuItem>();
        string item;
        //id for the menu
        //int id;
        DateTime lastUpdated = new DateTime();

        public Menu(string item, DateTime lastUpdated)
        {
            Item = item;
            LastUpdated = lastUpdated;
        }

        public string Item { get => item; set => item = value; }
        public DateTime LastUpdated { get => lastUpdated; set => lastUpdated = value; }

        public void AddMenuItem(MenuItem name)
        {
            if(!menuItems.Contains(name))
            {
                menuItems.Add(name);
            }
            else
            {
                Console.WriteLine("The item is already exists");
            }
        }

        public void RemoveMenuItem(MenuItem name)
        {
            if (menuItems.Contains(name))
            {
                menuItems.Remove(name);
            }
            else
            {
                Console.WriteLine("Item is not inside the menu");
            }
        }

        StringBuilder strBld = new StringBuilder();

        public void Builder()
        {

            for (int i = 0; i < menuItems.Count; i++)
            {
                strBld.Append("\nToday in menu:" + "\n" + menuItems[i] + "\n*******");
            }
        }

        public override string ToString()
        {
            Builder();
            return "\nToday menu: " + Item
                + "\nLast Updated: " + LastUpdated
                + strBld.ToString();
        }

    }
}
