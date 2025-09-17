using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2545 : IProblem
    {
        public bool Test()
        {
            var score = new[] { new[] { 10, 6, 9, 1 }, new[] { 7, 5, 11, 2 }, new[] { 4, 8, 3, 15 } };
            var k = 2;

            var expected = new[] { new[] { 7, 5, 11, 2 }, new[] { 10, 6, 9, 1 }, new[] { 4, 8, 3, 15 } };

            var result = SortTheStudents(score, k);

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(result, expected);
        }

        public int[][] SortTheStudents(int[][] score, int k)
        {
            Array.Sort(score, Comparer<int[]>.Create((x, y) => y[k].CompareTo(x[k])));
            return score;
        }
    }
}
