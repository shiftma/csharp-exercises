using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_CountingChar
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = @"Lorem ipsum dolor sit amet, consectetur adipiscing" +
                " elit.Nunc accumsan sem ut ligula scelerisque sollicitudin.Ut at sagittis augue." +
                "Praesent quis rhoncus justo.Aliquam erat volutpat." +
                "Donec sit amet suscipit metus, non lobortis massa.Vestibulum augue ex," +
                " dapibus ac suscipit vel, volutpat eget massa." +
                "Donec nec velit non ligula efficitur luctus.";

            foreach (var character in CountChar.Count(text))
            {
                Console.WriteLine("{0} - {1}", character.Key, character.Value);
                Console.ReadLine();
            }

        }
    }
}
