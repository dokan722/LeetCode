using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3418 : IProblem
    {
        public bool Test()
        {
            var coins = new[] {new[] {-7, 12, 12, 13}, new[] {-6, 19, 19, -6}, new[] {9, -2, -10, 16}, new[] {-4, 14, -10, -9}};

            var expected = 60;

            var result = MaximumAmount(coins);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximumAmount(int[][] coins)
        {
            var n = coins.Length;
            var m = coins[0].Length;
            var l = 3;
            var paths = new int[n][][];
            for (int i = 0; i < n; ++i)
            {
                paths[i] = new int[m][];
                for (int j = 0; j < m; ++j)
                    paths[i][j] = new int[l];
            }

            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (i == 0 && j == 0)
                    {
                        paths[i][j][0] = coins[0][0];
                        for (int k = 1; k < l; ++k)
                            paths[i][j][k] = Math.Max(0, coins[0][0]);
                    }
                    else
                    {
                        var up = i > 0 ? paths[i - 1][j][0] : int.MinValue;
                        var left = j > 0 ? paths[i][j - 1][0] : int.MinValue;
                        paths[i][j][0] = Math.Max(up, left) + coins[i][j];
                        for (int k = 1; k < l; ++k)
                        {
                            up = i > 0 ? paths[i - 1][j][k - 1] : int.MinValue;
                            left = j > 0 ? paths[i][j - 1][k - 1] : int.MinValue;
                            var upStay = i > 0 ? paths[i - 1][j][k] : int.MinValue;
                            var leftStay = j > 0 ? paths[i][j - 1][k] : int.MinValue;
                            paths[i][j][k] = Math.Max(Math.Max(upStay, leftStay) + coins[i][j], Math.Max(up, left) + Math.Max(0, coins[i][j]));
                        }
                    }
                }
            }

            return paths[n - 1][m - 1][l - 1];
        }
    }
}
