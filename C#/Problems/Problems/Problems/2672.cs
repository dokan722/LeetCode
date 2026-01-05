using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2672 : IProblem
    {
        public bool Test()
        {
            var n = 4;
            var queries = new[] { new[] { 0, 2 }, new[] { 1, 2 }, new[] { 3, 1 }, new[] { 1, 1 }, new[] { 2, 1 } };

            var expected = new[] { 0, 1, 1, 0, 2 };

            var result = ColorTheArray(n, queries);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] ColorTheArray(int n, int[][] queries)
        {
            var m = queries.Length;
            var curr = 0;
            var colors = new int[n + 2];
            var result = new int[m];
            for (int i = 0; i < m; ++i)
            {
                var query = queries[i];
                var id = query[0] + 1;
                if (colors[id] == query[1])
                {
                    result[i] = curr;
                    continue;
                }
                var prevL = (colors[id - 1] != 0 && colors[id] == colors[id - 1]) ? 1 : 0;
                var currL = (query[1] == colors[id - 1]) ? 1 : 0;
                var prevR = colors[id + 1] != 0 && (colors[id] == colors[id + 1]) ? 1 : 0;
                var currR = (query[1] == colors[id + 1]) ? 1 : 0;
                curr += currL + currR - prevL - prevR;
                colors[id] = query[1];
                result[i] = curr;
            }

            return result;
        }
    }
}
