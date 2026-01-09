using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1753 : IProblem
    {
        public bool Test()
        {
            var a = 4;
            var b = 4;
            var c = 6;

            var expected = 7;

            var result = MaximumScore(a, b, c);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaximumScore(int a, int b, int c)
        {
            var big = Math.Max(a, Math.Max(b, c));
            var total = a + b + c;
            var rest = total - big;
            return Math.Min(big, rest) + Math.Max(0, (rest - big) / 2);
        }
    }
}
