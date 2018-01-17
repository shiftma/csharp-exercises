using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 1, 2, 3, 5, 8, 13, 21 };
            int sum = 0;
            foreach (int i in x)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
