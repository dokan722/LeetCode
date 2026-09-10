using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3870 : IProblem
    {
        public bool Test()
        {
            var n = 1002;

            var expected = 3;

            var result = CountCommas(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountCommas(int n)
        {
            return Math.Max(n - 999, 0);
        }
    }
}
