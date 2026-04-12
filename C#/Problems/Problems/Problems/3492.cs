using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3492 : IProblem
    {
        public bool Test()
        {
            var n = 2;
            var w = 3;
            var maxWeight = 15;

            var expected = 4;

            var result = MaxContainers(n, w, maxWeight);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxContainers(int n, int w, int maxWeight)
        {
            var mc = maxWeight / w;
            return Math.Min(n * n, mc);
        }
    }
}
