using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3014 : IProblem
    {
        public bool Test()
        {
            var word = "abcde";

            var expected = 5;

            var result = MinimumPushes(word);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumPushes(string word)
        {
            var counts = new int[26];
            foreach (var c in word)
                counts[c - 'a']++;
            Array.Sort(counts);
            var result = 0;
            for (int i = 0; i < 26; ++i)
            {
                var times = (i + 8) / 8;
                result += times * counts[25 - i];
            }

            return result;
        }
    }
}
