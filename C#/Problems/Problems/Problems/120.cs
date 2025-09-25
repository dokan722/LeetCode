using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _120 : IProblem
    {
        public bool Test()
        {
            var triangle = new List<IList<int>>() { new List<int>() { 2 }, new List<int>() { 3, 4 }, new List<int>() { 6, 5, 7 }, new List<int>() { 4, 1, 8, 3 } };

            var expected = 11;

            var result = MinimumTotal(triangle);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinimumTotal(IList<IList<int>> triangle)
        {
            var n = triangle.Count;
            for (int i = n - 2; i >= 0; --i)
            {
                for (int j = 0; j <= i; ++j)
                    triangle[i][j] += Math.Min(triangle[i + 1][j], triangle[i + 1][j + 1]);
            }

            return triangle[0][0];
        }
    }
}
