using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1861 : IProblem
    {
        public bool Test()
        {
            var boxGrid = new[] { new[] { '#', '.', '#' } };

            var expected = new[] { new[] { '.' }, new[] { '#' }, new[] { '#' } };

            var result = RotateTheBox(boxGrid);

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }

        public char[][] RotateTheBox(char[][] boxGrid)
        {
            var n = boxGrid.Length;
            var m = boxGrid[0].Length;
            var result = new char[m][];
            for (int i = 0; i < m; ++i)
                result[i] = new char[n];
            for (int i = 0; i < n; ++i)
            {
                var cur = m - 1;
                for (int j = m - 1; j >= 0; --j)
                {
                    var cell = boxGrid[i][j];
                    if (cell == '#')
                    {
                        result[cur][n - 1 - i] = '#';
                        cur--;
                    }
                    else if (cell == '*')
                    {
                        for (int k = cur; k > j; --k)
                            result[k][n - 1 - i] = '.';
                        result[j][n - 1 - i] = '*';
                        cur = j - 1;
                    }
                }
                for (int j = cur; j >= 0; --j)
                    result[j][n - 1 - i] = '.';
            }

            return result;
        }
    }
}
