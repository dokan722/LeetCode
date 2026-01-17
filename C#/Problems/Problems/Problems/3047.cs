using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3047 : IProblem
    {
        public bool Test()
        {
            var bottomLeft = new[] { new[] { 1, 1 }, new[] { 2, 2 }, new[] { 3, 1 } };
            var topRight = new[] { new[] { 3, 3 }, new[] { 4, 4 }, new[] { 6, 6 } };

            var expected = 1;

            var result = LargestSquareArea(bottomLeft, topRight);

            Console.WriteLine(result);

            return result == expected;
        }
        public long LargestSquareArea(int[][] bottomLeft, int[][] topRight)
        {
            var n = bottomLeft.Length;
            long result = 0;
            for (int i = 0; i < n; ++i)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    var bottomBound = Math.Max(bottomLeft[i][1], bottomLeft[j][1]);
                    var topBound = Math.Min(topRight[i][1], topRight[j][1]);
                    var leftBound = Math.Max(bottomLeft[i][0], bottomLeft[j][0]);
                    var rightBound = Math.Min(topRight[i][0], topRight[j][0]);
                    var height = topBound - bottomBound;
                    var width = rightBound - leftBound;
                    long side = Math.Min(height, width);
                    if (side > 0)
                        result = Math.Max(result, side * side);
                }
            }

            return (int)result;
        }
    }
}
