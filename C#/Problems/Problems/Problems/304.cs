using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _304 : IProblem
    {
        public bool Test()
        {
            var numMatrix = new NumMatrix(new[] { new[] {3, 0, 1, 4, 2}, new [] {5, 6, 3, 2, 1}, new [] {1, 2, 0, 1, 5}, new [] {4, 1, 0, 1, 7}, new [] {1, 0, 3, 0, 5} });
            if (numMatrix.SumRegion(2, 1, 4, 3) != 8)
                return false;
            if (numMatrix.SumRegion(1, 1, 2, 2) != 11)
                return false;
            if (numMatrix.SumRegion(1, 2, 2, 4) != 12)
                return false;

            return true;
        }

        protected class NumMatrix
        {
            private int[][] _prefs;
            public NumMatrix(int[][] matrix)
            {
                var n = matrix.Length;
                var m = matrix[0].Length;
                _prefs = new int[n][];
                for (int i = 0; i < n; ++i)
                {
                    _prefs[i] = new int[m];
                    for (int j = 0; j < m; ++j)
                    {
                        var left = j > 0 ? _prefs[i][j - 1] : 0;
                        var up = i > 0 ? _prefs[i - 1][j] : 0;
                        var extra = i > 0 && j > 0 ? _prefs[i - 1][j - 1] : 0;
                        _prefs[i][j] = matrix[i][j] + left + up - extra;
                    }
                }
            }

            public int SumRegion(int row1, int col1, int row2, int col2)
            {
                var left = col1 > 0 ? _prefs[row2][col1 - 1] : 0;
                var up = row1 > 0 ? _prefs[row1 - 1][col2] : 0;
                var extra = col1 > 0 && row1 > 0 ? _prefs[row1 - 1][col1 - 1] : 0;
                return _prefs[row2][col2] - left - up + extra;
            }
        }
    }
}
