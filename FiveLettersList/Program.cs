using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiveLettersList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();

            Console.WriteLine("Enter a word: ");
            string newWord;

            do
            {
                newWord = Console.ReadLine();
                if (newWord != "")
                {
                    list.Add(newWord);
                }

            } while (newWord != "");

            foreach (string word in list)
            {
                if (word.Length == 5)
                {
                    Console.WriteLine(word);
                    Console.ReadLine();
                }
            }
        }
    }
}
