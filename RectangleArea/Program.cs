using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter rectangle length");
            decimal length = decimal.Parse(Console.ReadLine());

            Console.Write("Please enter rectangle width");
            decimal width = decimal.Parse(Console.ReadLine());

            decimal area = length * width;
            Console.WriteLine("The area of your rectangle is: {0}", area.ToString());
        }
    }
}
