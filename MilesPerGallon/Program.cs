using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MilesPerGallon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number of miles?");
            int miles = int.Parse(Console.ReadLine());

            Console.WriteLine("Amount of gas?");
            double gas = int.Parse(Console.ReadLine());

            double total = gas / miles;

            Console.WriteLine("Miles per gallon is: " + total.ToString());
            Console.ReadLine();
        }
    }
}
