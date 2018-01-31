using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class MenuItem
    {
        float price;
        string description;
        enum Category { appertizer, mainCourse, dessert };
        bool newItem;

        public MenuItem(float price, string description, bool newItem)
        {
            Price = price;
            Description = description;
            NewItem = newItem;
        }

        public float Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public bool NewItem { get => newItem; set => newItem = value; }
        
    }
}
