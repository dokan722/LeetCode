using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3137 : IProblem
    {
        public bool Test()
        {
            var word = "leetcodeleet";
            var k = 4;

            var expected = 1;

            var result = MinimumOperationsToMakeKPeriodic(word, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumOperationsToMakeKPeriodic(string word, int k)
        {
            var n = word.Length;
            var counts = new Dictionary<string, int>();
            var most = 0;
            for (int i = 0; i < n; i += k)
            {
                var cur = word.Substring(i, k);
                if (counts.ContainsKey(cur))
                    counts[cur]++;
                else
                    counts[cur] = 1;
                most = Math.Max(most, counts[cur]);
            }
            return (n / k) - most;
        }
    }
}
