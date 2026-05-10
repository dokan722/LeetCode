using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1914 : IProblem
    {
        public bool Test()
        {
            var grid = new[] { new[] { 40, 10 }, new[] { 30, 20 } };
            var k = 1;

            var expected = new[] { new[] { 10, 20 }, new[] { 40, 30 } };

            var result = RotateGrid(grid, k);

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }

        public int[][] RotateGrid(int[][] grid, int k)
        {
            var n = grid.Length;
            var m = grid[0].Length;
            var result = new int[n][];
            for (int i = 0; i < n; ++i)
                result[i] = new int[m];
            for (int i = 0; i < Math.Min(n, m) / 2; ++i)
            {
                var layerH = n - 2 * i;
                var layerW = m - 2 * i;
                var layerLen = 2 * layerH + 2 * layerW - 4;
                var d = k % layerLen;
                for (int j = 0; j < layerLen; ++j)
                {
                    var resCord = GetCoords(i, j, layerW, layerH, n, m);
                    var orgCord = GetCoords(i, (j + d) % layerLen, layerW, layerH, n, m);
                    result[resCord.X][resCord.Y] = grid[orgCord.X][orgCord.Y];
                }
            }

            return result;
        }

        private (int X, int Y) GetCoords(int layerNum, int pos, int layerW, int layerH, int h, int w)
        {
            var x = 0;
            var y = 0;
            if (pos < layerW)
            {
                x = layerNum;
                y = layerNum + pos;
            }
            else if (pos < layerW + layerH - 1)
            {
                x = layerNum + (pos - layerW + 1);
                y = w - 1 - layerNum;
            }
            else if (pos < 2 * layerW + layerH - 2)
            {
                x = h - layerNum - 1;
                y = w - 1 - layerNum - (pos - layerW - layerH + 2);
            }
            else
            {
                x = h - 1 - layerNum - (pos - 2 * layerW - layerH + 3);
                y = layerNum;
            }

            return (x, y);
        }
    }
}
