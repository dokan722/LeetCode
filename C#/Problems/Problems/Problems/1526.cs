using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1526 : IProblem
    {
        public bool Test()
        {
            var target = new[] { 3, 1, 5, 4, 2 };

            var expected = 7;

            var result = MinNumberOperations(target);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinNumberOperations(int[] target)
        {
            var n = target.Length;
            var result = target[0];
            for (int i = 1; i < n; ++i)
                result += Math.Max(0, target[i] - target[i - 1]);

            return result;
        }
    }
}
