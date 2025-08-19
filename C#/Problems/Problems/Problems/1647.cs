using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1647 : IProblem
    {
        public bool Test()
        {
            var s = "aaabbbcc";


            var expected = 2;

            var result = MinDeletions(s);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinDeletions(string s)
        {
            var counts = new int[26];
            foreach (var c in s)
                counts[c - 'a']++;
            var countsCounts = new Dictionary<int, int>();
            var usedCounts = new HashSet<int>();
            for (int i = 0; i < 26; ++i)
            {
                if (counts[i] == 0)
                    continue;
                usedCounts.Add(counts[i]);
                if (countsCounts.ContainsKey(counts[i]))
                    countsCounts[counts[i]]++;
                else
                    countsCounts[counts[i]] = 1;
            }

            var result = 0;

            foreach (var cc in countsCounts)
            {
                if (cc.Value > 1)
                {
                    var smaller = cc.Key;
                    while (smaller >= 0 && usedCounts.Contains(smaller))
                        smaller--;
                    for (int i = 0; i < cc.Value - 1; ++i)
                    {
                        if (smaller != 0)
                                usedCounts.Add(smaller);
                        result += cc.Key - smaller;
                        while (smaller >= 0 && usedCounts.Contains(smaller))
                                smaller--;
                    }
                }
            }

            return result;
        }
    }
}
