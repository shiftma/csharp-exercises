using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public enum Category { Appertizer, Main_Course, Dessert, Unknown };

    public class MenuItem
    {
        string name;
        float price;
        string description;
        bool newItem;
        public Category Category;

        public MenuItem(string name, float price, string description, bool newItem, Category category)
        {
            this.name = name;
            this.price = price;
            this.description = description;
            this.newItem = newItem;
            Category = category;
        }

        public MenuItem(string name)
            :this (name, 0, "", false, Category.Unknown)
        {
            Name = name;
        }

        public float Price { get => price; set => price = value; }
        public string Description { get => description; set => description = value; }
        public bool NewItem { get => newItem; set => newItem = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return Name + "\nPrice: "
                    + Price + "\nDescription: "
                    + Description + "\nCategory: "
                    + Category + "\n";
                
        }
    }
}
