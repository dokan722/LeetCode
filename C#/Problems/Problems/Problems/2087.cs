using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2087 : IProblem
    {
        public bool Test()
        {
            var startPos = new[] { 1, 0 };
            var homePos = new[] { 2, 3 };
            var rowCosts = new[] { 5, 4, 3 };
            var colCosts = new[] { 8, 2, 6, 7 };

            var expected = 18;

            var result = MinCost(startPos, homePos, rowCosts, colCosts);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinCost(int[] startPos, int[] homePos, int[] rowCosts, int[] colCosts)
        {
            var result = rowCosts[homePos[0]] + colCosts[homePos[1]] - rowCosts[startPos[0]] - colCosts[startPos[1]];
            var it = startPos[0] <= homePos[0] ? 1 : -1;
            for (int i = startPos[0]; i != homePos[0]; i += it)
                result += rowCosts[i];
            it = startPos[1] <= homePos[1] ? 1 : -1;
            for (int i = startPos[1]; i != homePos[1]; i += it)
                result += colCosts[i];
            return result;
        }
    }
}
