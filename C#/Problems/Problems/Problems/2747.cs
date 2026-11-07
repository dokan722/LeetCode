using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2747 : IProblem
    {
        public bool Test()
        {
            var n = 3;
            var logs = new[] { new[] { 2, 4 }, new[] { 2, 1 }, new[] { 1, 2 }, new[] { 3, 1 } };
            var x = 2;
            var queries = new[] { 3, 4 };

            var expceted = new[] { 0, 1 };

            var result = CountServers(n, logs, x, queries);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expceted, result);
        }

        public int[] CountServers(int n, int[][] logs, int x, int[] queries)
        {
            var m = queries.Length;
            var k = logs.Length;
            var order = Enumerable.Range(0, m).ToArray();
            Array.Sort(logs, Comparer<int[]>.Create((x, y) => x[1].CompareTo(y[1])));
            Array.Sort(order, Comparer<int>.Create((x, y) => queries[x].CompareTo(queries[y])));
            var counts = new Dictionary<int, int>();
            var result = new int[m];
            var l = 0;
            var r = 0;
            for (int i = 0; i < m; ++i)
            {
                var q = queries[order[i]];
                while (r < k && logs[r][1] <= q)
                {
                    if (counts.ContainsKey(logs[r][0]))
                        counts[logs[r][0]]++;
                    else
                        counts[logs[r][0]] = 1;
                    r++;
                }
                while (l < k && logs[l][1] < q - x)
                {
                    counts[logs[l][0]]--;
                    if (counts[logs[l][0]] == 0)
                        counts.Remove(logs[l][0]);
                    l++;
                }
                result[order[i]] = n - counts.Count;
            }
            return result;
        }
    }
}
