using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1582 : IProblem
    {
        public bool Test()
        {
            var mat = new[] { new[] { 1, 0, 0 }, new[] { 0, 0, 1 }, new[] { 1, 0, 0 } };

            var expected = 1;

            var result = NumSpecial(mat);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumSpecial(int[][] mat)
        {
            var n = mat.Length;
            var m = mat[0].Length;
            var rowCounts = new int[n];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                    rowCounts[i] += mat[i][j];
            }

            var result = 0;
            for (int j = 0; j < m; ++j)
            {
                var hasSpecial = false;
                var colCount = 0;
                for (int i = 0; i < n; ++i)
                {
                    if (mat[i][j] == 1)
                    {
                        colCount += 1;
                        if (rowCounts[i] == 1)
                            hasSpecial = true;
                    }
                }
                if (hasSpecial && colCount == 1)
                    result++;
            }

            return result;
        }
    }
}
