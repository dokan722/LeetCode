using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1520 : IProblem
    {
        public bool Test()
        {
            var s = "adefaddaccc";

            var expected = new[] { "e", "f", "ccc" };

            var result = MaxNumOfSubstrings(s);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<string> MaxNumOfSubstrings(string s)
        {
            var n = s.Length;
            var first = Enumerable.Repeat(-1, 26).ToArray();
            var last = new int[26];
            for (int i = 0; i < n; ++i)
            {
                var id = s[i] - 'a';
                if (first[id] == -1)
                    first[id] = i;
                last[id] = i;
            }
            for (int i = 0; i < 26; ++i)
            {
                if (first[i] == -1)
                    continue;
                var j = first[i];
                while (j <= last[i])
                {
                    var id = s[j] - 'a';
                    if (first[id] < first[i] || last[id] > last[i])
                    {
                        first[i] = Math.Min(first[i], first[id]);
                        last[i] = Math.Max(last[i], last[id]);
                        j = first[i];
                    }
                    j++;
                }
            }
            var sorted = Enumerable.Range(0, 26).OrderBy(x => last[x]).ThenBy(x => first[x]).ToArray();
            var end = -1;
            var result = new List<string>();
            for (int i = 0; i < 26; ++i)
            {
                if (first[sorted[i]] == -1)
                    continue;
                if (first[sorted[i]] > end)
                {
                    result.Add(s.Substring(first[sorted[i]], last[sorted[i]] - first[sorted[i]] + 1));
                    end = last[sorted[i]];
                }
            }

            return result;
        }
    }
}
