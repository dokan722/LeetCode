using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1232 : IProblem
    {
        public bool Test()
        {
            var coordinates = new[] {new[] {1, 2}, new[] {2, 3}, new[] {3, 4}, new[] {4, 5}, new[] {5, 6}, new[] {6, 7}};

            var expected = true;

            var result = CheckStraightLine(coordinates);

            return result == expected;
        }

        public bool CheckStraightLine(int[][] coordinates)
        {
            var n = coordinates.Length;
            var x1 = coordinates[0][0];
            var x2 = coordinates[1][0];
            var y1 = coordinates[0][1];
            var y2 = coordinates[1][1];
            for (int i = 2; i < n; ++i)
            {
                var x = coordinates[i][0];
                var y = coordinates[i][1];
                if ((y - y2) * (x2 - x1) != (y2 - y1) * (x - x2))
                    return false;
            }

            return true;
        }
    }
}
