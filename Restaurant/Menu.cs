using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Menu
    {
        List<string> MenuItems = new List<string>();

        string item;
        DateTime lastUpdated = new DateTime();

        public Menu(string item, DateTime lastUpdated)
        {
            Item = item;
            LastUpdated = lastUpdated;
        }

        public string Item { get => item; set => item = value; }
        public DateTime LastUpdated { get => lastUpdated; set => lastUpdated = value; }

        public static void CreateMenu(MenuItem item, float price, string description, Boolean isNew)
        {
            item = new MenuItem(price, description, isNew);
        }
         
        
    }
}
