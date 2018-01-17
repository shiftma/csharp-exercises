using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a radius: ");
            string radius = Console.ReadLine();

            int r = 0;
            if (int.TryParse(radius, out r))
            {
                if (r > 0)
                {
                    double area = Math.PI * Math.Pow(r, 2);
                    string result = Math.Round(area).ToString();

                    Console.WriteLine("The area of a circle with radius {0} is: {1}", arg0: r, arg1: result);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Radius cannot be less then zero!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Radius should be an intenger");
                Console.ReadLine();
            }            
        }
    }
}
