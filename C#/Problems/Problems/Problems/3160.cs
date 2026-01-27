using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3160 : IProblem
    {
        public bool Test()
        {
            var limit = 4;
            var queries = new[] { new[] { 1, 4 }, new[] { 2, 5 }, new[] { 1, 3 }, new[] { 3, 4 } };

            var expected = new[] { 1, 2, 2, 3 };

            var result = QueryResults(limit, queries);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }
        public int[] QueryResults(int limit, int[][] queries)
        {
            var n = queries.Length;
            var color = new Dictionary<int, int>();
            var colorCounts = new Dictionary<int, int>();
            colorCounts[0] = n + 1;
            var colors = 0;
            var result = new int[n];
            for (int i = 0; i < n; ++i)
            {
                var oldColor = color.ContainsKey(queries[i][0]) ? color[queries[i][0]] : 0;
                var newColor = queries[i][1];
                color[queries[i][0]] = newColor;
                colorCounts[oldColor]--;
                if (colorCounts[oldColor] == 0)
                    colorCounts.Remove(oldColor);
                if (!colorCounts.ContainsKey(newColor))
                    colorCounts[newColor] = 0;
                colorCounts[newColor]++;
                result[i] = colorCounts.Count - 1;
            }

            return result;
        }
    }
}
