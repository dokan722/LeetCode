using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3713 : IProblem
    {
        public bool Test()
        {
            var s = "zzabccy";

            var expected = 4;

            var result = LongestBalanced(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LongestBalanced(string s)
        {
            var n = s.Length;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                var counts = new int[26];
                for (int j = i; j < n; ++j)
                {
                    counts[s[j] - 'a']++;
                    var exp = counts[s[j] - 'a'];
                    var same = true;
                    for (int k = 0; k < 26; ++k)
                    {
                        if (counts[k] != 0 && counts[k] != exp)
                        {
                            same = false;
                            break;
                        }
                    }
                    if (same)
                        result = Math.Max(j - i + 1, result);
                }
            }

            return result;
        }
    }
}
