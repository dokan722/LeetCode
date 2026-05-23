using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _789 : IProblem
    {
        public bool Test()
        {
            var ghosts = new[] { new[] { 1, 0 }, new[] { 0, 3 } };
            var target = new[] { 0, 1 };

            var expected = true;

            var result = EscapeGhosts(ghosts, target);

            return result == expected;
        }

        public bool EscapeGhosts(int[][] ghosts, int[] target)
        {
            var dist = Math.Abs(target[0]) + Math.Abs(target[1]);
            foreach (var g in ghosts)
            {
                if (dist >= Math.Abs(target[0] - g[0]) + Math.Abs(target[1] - g[1]))
                    return false;
            }

            return true;
        }
    }
}
