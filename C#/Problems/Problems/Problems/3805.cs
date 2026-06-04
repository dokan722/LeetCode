using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3805 : IProblem
    {
        public bool Test()
        {
            var words = new[] { "ab", "aa", "za", "aa" };

            var expected = 2;

            var result = CountPairs(words);

            Console.WriteLine(result);

            return result == expected;
        }

        public long CountPairs(string[] words)
        {
            var m = words[0].Length;
            long result = 0;
            var counts = new Dictionary<string, int>();
            foreach (var w in words)
            {
                var a = w.ToCharArray();
                var b = a[0] - 'a';
                for (int i = 0; i < m; ++i)
                    a[i] = (char)((a[i] - b + 26) % 26);
                var s = new string(a);
                if (counts.ContainsKey(s))
                    result += counts[s]++;
                else
                    counts[s] = 1;
            }
            return result;
        }
    }
}
