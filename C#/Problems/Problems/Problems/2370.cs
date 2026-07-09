using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2370 : IProblem
    {
        public bool Test()
        {
            var s = "acfgbd";
            var k = 2;

            var expected = 4;

            var result = LongestIdealString(s, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int LongestIdealString(string s, int k)
        {
            var n = s.Length;
            var result = 1;
            var lens = new int[26];
            for (int i = 0; i < n; ++i)
            {
                var id = s[i] - 'a';
                var best = 0;
                var from = Math.Max(0, id - k);
                var to = Math.Min(25, id + k);
                for (int j = from; j <= to; ++j)
                    best = Math.Max(best, lens[j]);
                lens[id] = best + 1;
            }
            for (int i = 0; i < 26; ++i)
                result = Math.Max(result, lens[i]);
            return result;
        }
    }
}
