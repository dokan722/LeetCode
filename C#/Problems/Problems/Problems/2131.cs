using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2131 : IProblem
    {
        public bool Test()
        {
            var words = new[] { "lc", "cl", "gg" };

            var expected = 6;

            var result = LongestPalindrome(words);

            Console.WriteLine(result);

            return expected == result;
        }
        public int LongestPalindrome(string[] words)
        {
            var pairs = new int[26][];
            for (int i = 0; i < 26; ++i)
                pairs[i] = new int[26];
            foreach (var word in words)
            {
                pairs[word[0] - 'a'][word[1] - 'a']++;
            }

            var sidePairs = 0;
            var anyOdd = false;
            for (int i = 0; i < 26; ++i)
            {
                anyOdd = anyOdd || (pairs[i][i] % 2 == 1);
                sidePairs += pairs[i][i] / 2;
                for (int j = i + 1; j < 26; ++j)
                {
                    sidePairs += Math.Min(pairs[i][j], pairs[j][i]);
                }
            }

            return sidePairs * 4 + (anyOdd ? 2 : 0);
        }

    }
}
