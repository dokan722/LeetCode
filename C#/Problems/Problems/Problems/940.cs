using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _940 : IProblem
    {
        public bool Test()
        {
            var s = "abc";

            var expected = 7;

            var result = DistinctSubseqII(s);

            Console.WriteLine(result);

            return result == expected;
        }


        public int DistinctSubseqII(string s)
        {
            long result = 0;
            var prev = new long[26];
            var mod = 1000000007;
            foreach (var c in s)
            {
                var id = c - 'a';
                var next = (result + 1 - prev[id] + mod) % mod;
                result = (result + next) % mod;
                prev[id] = (prev[id] + next) % mod;
            }

            return (int)result;
        }

        // pierwsze rozwiązanie - nieoptymalne
        public int DistinctSubseqIINie(string s)
        {
            var n = s.Length;
            var count = new long[n];
            var pos = Enumerable.Repeat(-1, 26).ToArray();
            count[0] = 1;
            pos[s[0] - 'a'] = 0;
            for (int i = 1; i < n; ++i)
            {
                var id = s[i] - 'a';
                if (pos[id] == -1)
                {
                    pos[id] = i;
                    count[i]++;
                }
                count[i] += count[i - 1];
            }
            long total = count[n - 1];
            var mod = 1000000007;
            for (int i = 1; i < n; ++i)
            {
                var next = new long[n];
                pos = Enumerable.Repeat(-1, 26).ToArray();
                for (int j = i; j < n; ++j)
                {
                    var id = s[j] - 'a';
                    var cnt = pos[id] == -1 ? count[j - 1] : count[j - 1] - count[pos[id] - 1];
                    next[j] = (cnt + next[j - 1]) % mod;
                    pos[id] = j;
                }
                count = next;
                total = (total + count[n - 1]) % mod;
            }

            return (int)total;
        }
    }
}
