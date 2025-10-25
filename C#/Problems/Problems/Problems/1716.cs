using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1716 : IProblem
    {
        public bool Test()
        {
            var n = 20;

            var expected = 96;

            var result = TotalMoney(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int TotalMoney(int n)
        {
            var full = n / 7;
            var rest = n % 7;
            return 7 * full * (full - 1) / 2 + 28 * full + rest * full + rest * (rest + 1) / 2;
        }
    }
}
