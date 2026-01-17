using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems.Problems;

namespace Problems.Contests.BiWeekly174
{
    public class _1 : IProblem
    {
        public bool Test()
        {
            var towers = new[] { new[] { 1, 2, 5 }, new[] { 2, 1, 7 }, new[] { 3, 1, 9 } };
            var center = new[] { 1, 1 };
            var radious = 2;

            var expected = new[] { 3, 1 };

            var result = BestTower(towers, center, radious);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }
        public int[] BestTower(int[][] towers, int[] center, int radius)
        {
            var result = new[] { -1, -1, -1 };
            foreach (var tower in towers)
            {
                var dist = Math.Abs(center[0] - tower[0]) + Math.Abs(center[1] - tower[1]);
                if (dist <= radius)
                {
                    if (tower[2] > result[2] || (tower[2] == result[2] && ((tower[0] < result[0]) || (tower[0] == result[0] && tower[1] < result[1]))))
                    {
                        result = tower;
                    }
                }
            }

            return new[] { result[0], result[1] };
        }

    }
}
