using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _451 : IProblem
    {
        public bool Test()
        {
            var s = "Aabb";

            var expected = "bbaA";

            var result = FrequencySort(s);

            Console.WriteLine(result);

            return expected == result;
        }

        public string FrequencySort(string s)
        {
            var counts = new Dictionary<char, int>();
            foreach (char c in s)
            {
                if (counts.ContainsKey(c))
                    counts[c]++;
                else
                    counts[c] = 1;
            }

            var chars = counts.Count;
            var pairs = new (int, char)[chars];
            var i = 0;
            foreach (var count in counts)
            {
                pairs[i] = (count.Value, count.Key);
                i++;
            }
            Array.Sort(pairs, (x, y) => y.CompareTo(x));
            var result = string.Empty;
            foreach (var pair in pairs)
            {
                result += new string(pair.Item2, pair.Item1);
            }

            return result;
        }
    }
}
