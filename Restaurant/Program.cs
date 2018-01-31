using School;
using System;

namespace Restaurant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Student mike = new Student("Mike", 32, 8, 3.2f);
            Console.WriteLine(mike.GetGradeLevel());
            Console.ReadLine();
        }
    }
}
