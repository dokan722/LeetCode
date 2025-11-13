using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1525 : IProblem
    {
        public bool Test()
        {
            var s = "aacaba";

            var expected = 2;

            var result = NumSplits(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumSplits(string s)
        {
            var n = s.Length;
            var counts = new Dictionary<int, int>();

            foreach (var c in s)
            {
                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                    counts[c] = 1;
            }

            var result = 0;
            var currCounts = new Dictionary<int, int>();
            foreach (var c in s.Substring(0, n - 1))
            {
                if (currCounts.ContainsKey(c))
                    currCounts[c]++;
                else
                    currCounts[c] = 1;
                if (counts[c] > 1)
                    counts[c]--;
                else
                    counts.Remove(c);
                if (currCounts.Count == counts.Count)
                    result++;
            }

            return result;
        }
    }
}
