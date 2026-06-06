using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1936 : IProblem
    {
        public bool Test()
        {
            var rungs = new[] { 1, 3, 5, 10 };
            var dist = 2;

            var expected = 2;

            var result = AddRungs(rungs, dist);

            Console.WriteLine(result);

            return expected == result;
        }

        public int AddRungs(int[] rungs, int dist)
        {
            var th = dist;
            var result = 0;
            foreach (var rung in rungs)
            {
                if (rung > th)
                {
                    var left = rung - th;
                    result += (left + dist - 1) / dist;
                }
                th = rung + dist;
            }

            return result;
        }
    }
}
