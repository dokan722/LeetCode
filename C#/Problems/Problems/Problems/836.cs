using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _836 : IProblem
    {
        public bool Test()
        {
            var rec1 = new[] { 0, 0, 2, 2 };
            var rec2 = new[] { 1, 1, 3, 3 };

            var expected = true;

            var result = IsRectangleOverlap(rec1, rec2);

            return result == expected;
        }

        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            return rec1[0] < rec2[2] && rec1[2] > rec2[0] && rec1[1] < rec2[3] && rec1[3] > rec2[1];
        }
    }
}
