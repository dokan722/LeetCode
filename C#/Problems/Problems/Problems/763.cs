using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _763 : IProblem
    {
        public bool Test()
        {
            var s = "ababcbacadefegdehijhklij";

            var expected = new[] { 9, 7, 8 };

            var result = PartitionLabels(s);

            Utils.Print1DArray(result.ToArray());

            return result.SequenceEqual(expected);
        }

        public IList<int> PartitionLabels(string s)
        {
            var n = s.Length;
            var last = new int[26];
            for (int i = 0; i < n; ++i)
                last[s[i] - 'a'] = i;

            var start = -1;
            var end = 0;
            var result = new List<int>();
            for (int i = 0; i < n; ++i)
            {
                end = Math.Max(end, last[s[i] - 'a']);
                if (end == i)
                {
                    result.Add(end - start);
                    start = i;
                }
            }

            return result;
        }
    }
}
