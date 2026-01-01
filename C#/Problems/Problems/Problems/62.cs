using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _62 : IProblem
    {
        public bool Test()
        {
            var m = 3;
            var n = 7;

            var expected = 28;

            var result = UniquePaths(m, n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int UniquePaths(int m, int n)
        {
            var from = m + n - 2;
            var choose = Math.Min(m, n) - 1;
            var mod = 2000000000;
            long result = 1;
            for (int i = 1; i <= choose; i++)
            {
                result = result * (from - choose + i) / i % mod;
            }

            return (int)result;
        }
    }
}
