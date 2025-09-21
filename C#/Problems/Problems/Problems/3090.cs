using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3090 : IProblem
    {
        public bool Test()
        {
            var s = "bcbbbcba";

            var expected = 4;

            var result = MaximumLengthSubstring(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximumLengthSubstring(string s)
        {
            var n = s.Length;
            var counts = new int[26];
            var j = 0;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                counts[s[i] - 'a']++;
                if (counts[s[i] - 'a'] == 3)
                {
                    result = Math.Max(i - j, result);
                    while (counts[s[i] - 'a'] == 3)
                    {
                        counts[s[j] - 'a']--;
                        j++;
                    }
                }
            }

            return Math.Max(n - j, result);
        }
    }
}
