using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1930 : IProblem
    {
        public bool Test()
        {
            var s = "bbcbaba";

            var expected = 4;

            var result = CountPalindromicSubsequence(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountPalindromicSubsequence(string s)
        {
            var n = s.Length;
            var counts = new int[26];
            for (int i = 0; i < n; ++i)
                counts[s[i] - 'a']++;

            var currCounts = new int[26];
            var allPals = new HashSet<(int, int)>();
            for (int i = 0; i < n; ++i)
            {
                var id = s[i] - 'a';
                counts[id]--;
                for (int j = 0; j < 26; ++j)
                {
                    if (counts[j] > 0 && currCounts[j] > 0)
                        allPals.Add((j, id));
                }

                currCounts[id]++;
            }

            return allPals.Count;
        }
    }
}
