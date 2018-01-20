using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Studio_CountingChar
{
    class CountChar
    {
        public static SortedDictionary<char, int> Count(string stringToCount)
        {
            SortedDictionary<char, int> characterCount = new SortedDictionary<char, int>();

            foreach (var character in stringToCount)
            {
                characterCount.TryGetValue(character, out int counter);
                characterCount[character] = counter + 1;
            }
            return characterCount;
        }
    }
}
