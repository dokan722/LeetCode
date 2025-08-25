using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1605 : IProblem
    {
        public bool Test()
        {
            var rowSum = new[] { 3, 8 };
            var colSum = new[] { 4, 7 };

            var expected = new[] { new[] { 3, 0 }, new[] { 1, 7 } };

            var result = RestoreMatrix(rowSum, colSum);

            foreach (var (row, rowExpected) in result.Zip(expected))
            {
                if (!row.SequenceEqual(rowExpected))
                    return false;
            }

            return true;
        }

        public int[][] RestoreMatrix(int[] rowSum, int[] colSum)
        {
            int n = rowSum.Length;
            int m = colSum.Length;
            var result = new int[n][];
            for (int k = 0; k < n; ++k)
                result[k] = new int[m];
            int i = 0;
            int j = 0;
            
            while (i < n && j < m)
            {
                var value = Math.Min(rowSum[i], colSum[j]);
                result[i][j] = value;
                rowSum[i] -= value;
                colSum[j] -= value;
                if (rowSum[i] == 0)
                    i++;
                if (colSum[j] == 0)
                    j++;
            }

            return result;
        }
    }
}
