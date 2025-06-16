using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _417 : IProblem
    {
        public bool Test()
        {
            int[][] h = { new int[] {1,2,2,3,5}, new int[] {3, 2, 3, 4, 4}, new int[] {2, 4, 5, 3, 1}, new int[] {6, 7, 1, 4, 5}, new int[] {5, 1, 1, 2, 4} };

            var expected = new List<List<int>>
            {
                new List<int> { 0, 4 }, new List<int> { 1, 3 }, new List<int> { 1, 4 }, new List<int> { 2, 2 },
                new List<int> { 3, 0 }, new List<int> { 3, 1 }, new List<int> { 4, 0 }
            };

            var result = PacificAtlantic(h);

            if (result.Count != expected.Count)
                return false;

            foreach (var cell in expected)
            {
                if (!result.Any(x => x.SequenceEqual(cell)))
                    return false;
            }

            return true;
        }

        public IList<IList<int>> PacificAtlantic(int[][] heights)
        {
            var m = heights.Length;
            var n = heights[0].Length;
            var pacificCoverage = new bool[m, n];
            var atlanticCoverage = new bool[m, n];
            var result = new List<IList<int>>();

            for (int i = 0; i < m; ++i)
                DfsCover(i, 0, heights, pacificCoverage);
            for (int i = 0; i < n; ++i)
                DfsCover(0, i, heights, pacificCoverage);
            for (int i = 0; i < m; ++i)
                DfsCover(i, n - 1, heights, atlanticCoverage);
            for (int i = 0; i < n; ++i)
                DfsCover(m - 1, i, heights, atlanticCoverage);

            for (int i = 0; i < m; ++i)
            {
                for (int j = 0; j < n; ++j)
                {
                    if (pacificCoverage[i, j] && atlanticCoverage[i, j])
                        result.Add(new List<int> {i, j});
                }
            }

            return result;
        }

        private void DfsCover(int i, int j, int[][] heights, bool[,] coverage)
        {
            if (coverage[i, j])
                return;
            coverage[i, j] = true;

            if (i - 1 >= 0 && heights[i][j] <= heights[i - 1][j])
                DfsCover(i - 1, j, heights, coverage);

            if (j - 1 >= 0 && heights[i][j] <= heights[i][j - 1])
                DfsCover(i, j - 1, heights, coverage);

            if (i + 1 < coverage.GetLength(0) && heights[i][j] <= heights[i + 1][j])
                DfsCover(i + 1, j, heights, coverage);

            if (j + 1 < coverage.GetLength(1) && heights[i][j] <= heights[i][j + 1])
                DfsCover(i, j + 1, heights, coverage);
        }
    }
}
