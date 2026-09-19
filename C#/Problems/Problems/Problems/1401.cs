using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1401 : IProblem
    {
        public bool Test()
        {
            var radius = 1;
            var xCenter = 0;
            var yCenter = 0;
            var x1 = 1;
            var y1 = -1;
            var x2 = 3;
            var y2 = 1;

            var expected = true;

            var result = CheckOverlap(radius, xCenter, yCenter, x1, y1, x2, y2);

            return expected == result;
        }

        public bool CheckOverlap(int radius, int xCenter, int yCenter, int x1, int y1, int x2, int y2)
        {
            var dx = Math.Max(x1, Math.Min(xCenter, x2)) - xCenter;
            var dy = Math.Max(y1, Math.Min(yCenter, y2)) - yCenter;

            return dx * dx + dy * dy <= radius * radius;
        }
    }
}
