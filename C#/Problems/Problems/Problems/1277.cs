using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1277 : IProblem
    {
        public bool Test()
        {
            var matrix = new[] { new[] { 0, 1, 1, 1 }, new[] { 1, 1, 1, 1 }, new[] { 0, 1, 1, 1 } };

            var expected = 15;

            var result = CountSquares(matrix);

            Console.WriteLine(result);

            return expected == result;
        }

        public int CountSquares(int[][] matrix)
        {
            var n = matrix.Length;
            var m = matrix[0].Length;
            var endingSquares = new int[n][];
            for (int i = 0; i < n; ++i)
                endingSquares[i] = new int[m];

            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = 0; j < m; ++j)
                {
                    if (matrix[i][j] == 0)
                        endingSquares[i][j] = 0;
                    else
                    {
                        if (i > 0 && j > 0 && matrix[i][j - 1] == 1 && matrix[i - 1][j] == 1 && matrix[i - 1][j - 1] == 1)
                            endingSquares[i][j] = 1 + Math.Min(Math.Min(endingSquares[i][j - 1], endingSquares[i - 1][j]), endingSquares[i - 1][j - 1]);
                        else
                            endingSquares[i][j] = 1;
                        result += endingSquares[i][j];
                    }
                }
            }

            return result;
        }
    }
}
