using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2661 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 2, 8, 7, 4, 1, 3, 5, 6, 9 };
            var mat = new[] { new[] { 3, 2, 5 }, new[] { 1, 4, 6 }, new[] { 8, 7, 9 } };

            var expected = 3;

            var result = FirstCompleteIndex(arr, mat);

            Console.WriteLine(result);

            return expected == result;
        }

        public int FirstCompleteIndex(int[] arr, int[][] mat)
        {
            var n = mat.Length;
            var m = mat[0].Length;
            var nm = n * m;
            var pos = new (int, int)[nm + 1];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                    pos[mat[i][j]] = (i, j);
            }

            var rows = new int[n];
            var cols = new int[m];
            for (int i = 0; i < nm; ++i)
            {
                var p = pos[arr[i]];
                rows[p.Item1]++;
                cols[p.Item2]++;
                if (rows[p.Item1] == m || cols[p.Item2] == n)
                    return i;
            }

            return -1;
        }
    }
}
