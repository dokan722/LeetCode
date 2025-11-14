using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2829 : IProblem
    {
        public bool Test()
        {
            var n = 5;
            var k = 4;

            var expected = 18;

            var result = MinimumSum(n, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinimumSum(int n, int k)
        {
            var half = k / 2;
            if (k < 3 || half > n)
                return n * (n + 1) / 2;
            var end = n + (k - half);
            return half * (half + 1) / 2 - k * (k - 1) / 2 + end * (end - 1) / 2;
        }
    }
}
