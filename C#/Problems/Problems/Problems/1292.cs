using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1292 : IProblem
    {
        public bool Test()
        {
            var mat = new[]{new[]{ 1, 1, 3, 2, 4, 3, 2 }, new[]{ 1, 1, 3, 2, 4, 3, 2 }, new[]{ 1, 1, 3, 2, 4, 3, 2}};
            var threshold = 4;

            var expected = 2;

            var result = MaxSideLength(mat, threshold);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxSideLength(int[][] mat, int threshold)
        {
            var n = mat.Length;
            var m = mat[0].Length;
            var pref = new int[n + 1][];
            for (int i = 0; i <= n; ++i)
                pref[i] = new int[m + 1];
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                    pref[i + 1][j + 1] = mat[i][j] + pref[i][j + 1] + pref[i + 1][j] - pref[i][j];
            }

            var l = 0;
            var r = Math.Min(n, m);
            while (l < r)
            {
                var mid = (l + r + 1) / 2;
                var possible = false;
                var horizontal = n - mid + 1;
                var vertical = m - mid + 1;
                for (int i = 0; i < horizontal; ++i)
                {
                    for (int j = 0; j < vertical; ++j)
                    {
                        if (pref[i + mid][j + mid] - pref[i + mid][j] - pref[i][j + mid] + pref[i][j] <= threshold)
                        {
                            possible = true;
                            break;
                        }
                    }
                    if (possible)
                        break;
                }
                if (possible)
                    l = mid;
                else
                    r = mid - 1;
            }

            return l;
        }
    }
}
