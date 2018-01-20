using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfThings
{
    class Program
    {
        static void Main(string[] args)
        {
        
            int[] arrayOfThings = new int[] { 1, 1, 2, 3, 5, 8 };

            foreach (int num in arrayOfThings)
            {
                Console.WriteLine(num);
                Console.ReadLine();
            }

            

        }
    }
}
