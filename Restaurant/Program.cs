using School;
using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuItem pancakes = new MenuItem("Pancakes", 8, "Whole wheat baked", true, Category.Dessert);
            MenuItem soup = new MenuItem("Soup", 6, "Winter vegetable soup", false, Category.Main_Course);

            Menu day1 = new Menu("Monday", DateTime.Today);
            day1.AddMenuItem(pancakes);
            day1.AddMenuItem(soup);

            Console.WriteLine(day1);


            //Console.WriteLine(pancakes);
            //Console.WriteLine();
            //Console.WriteLine(soup);
            //Console.WriteLine();

            Console.ReadLine();

        }
    }
}
