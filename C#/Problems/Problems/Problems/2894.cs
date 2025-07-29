using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2894 : IProblem
    {
        public bool Test()
        {
            var n = 10;
            var m = 3;

            var expected = 19;

            var result = DifferenceOfSums(n, m);

            Console.WriteLine(result);

            return result == expected;
        }

        public int DifferenceOfSums(int n, int m)
        {
            var num = (int)Math.Floor((double)n / m);

            return ((n * (n + 1) / 2)) - ((num * (num + 1)) / 2) * 2 * m;
        }
    }
}
