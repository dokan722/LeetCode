using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3516 : IProblem
    {
        public bool Test()
        {
            var x = 2;
            var y = 7;
            var z = 4;

            var expected = 1;

            var result = FindClosest(x, y, z);

            return result == expected;
        }


        public int FindClosest(int x, int y, int z)
        {
            var dist1 = Math.Abs(x - z);
            var dist2 = Math.Abs(y - z);
            if (dist1 == dist2)
                return 0;
            return dist1 < dist2 ? 1 : 2;
        }
    }
}
