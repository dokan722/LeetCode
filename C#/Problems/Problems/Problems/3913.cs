using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3913 : IProblem
    {
        public bool Test()
        {
            var s = "leetcode";

            var expected = "leetcedo";

            var result = SortVowels(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public string SortVowels(string s)
        {
            var n = s.Length;
            var vowels = new[] { 'a', 'e', 'i', 'o', 'u' };
            var first = new[] { -1, -1, -1, -1, -1 };
            var counts = new int[5];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < 5; ++j)
                {
                    if (s[i] == vowels[j])
                    {
                        if (first[j] == -1)
                            first[j] = i;
                        counts[j]++;
                    }
                }
            }
            var ids = new[] { 0, 1, 2, 3, 4 };
            ids = ids.OrderBy(x => -counts[x]).ThenBy(x => first[x]).ToArray();
            var cur = 0;
            var result = new StringBuilder();
            for (int i = 0; i < n; ++i)
            {
                var vowel = false;
                for (int j = 0; j < 5; ++j)
                {
                    if (s[i] == vowels[j])
                    {
                        vowel = true;
                        break;
                    }
                }
                if (vowel)
                {
                    while (counts[ids[cur]] == 0)
                        cur++;
                    result.Append(vowels[ids[cur]]);
                    counts[ids[cur]]--;
                }
                else
                    result.Append(s[i]);
            }

            return result.ToString();
        }
    }
}
