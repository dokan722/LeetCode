using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3531 : IProblem
    {
        public bool Test()
        {
            var n = 3;
            var buildings = new[] { new[] { 1, 2 }, new[] { 2, 2 }, new[] { 3, 2 }, new[] { 2, 1 }, new[] { 2, 3 } };

            var expected = 1;

            var result = CountCoveredBuildings(n, buildings);

            Console.WriteLine(result);

            return expected == result;
        }

        public int CountCoveredBuildings(int n, int[][] buildings)
        {
            var maxX = new int[n + 1];
            var maxY = new int[n + 1];
            var minX = new int[n + 1];
            var minY = new int[n + 1];
            Array.Fill(minX, int.MaxValue);
            Array.Fill(minY, int.MaxValue);
            
            foreach (var b in buildings)
            {
                maxX[b[1]] = Math.Max(maxX[b[1]], b[0]);
                maxY[b[0]] = Math.Max(maxY[b[0]], b[1]);
                minX[b[1]] = Math.Min(minX[b[1]], b[0]);
                minY[b[0]] = Math.Min(minY[b[0]], b[1]);
            }

            var result = 0;
            foreach (var b in buildings)
            {
                if (maxX[b[1]] > b[0] && minX[b[1]] < b[0] && maxY[b[0]] > b[1] && minY[b[0]] < b[1])
                    result++;
            }

            return result;
        }
    }
}
