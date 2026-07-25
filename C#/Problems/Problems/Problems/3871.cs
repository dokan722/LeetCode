using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3871 : IProblem
    {
        public bool Test()
        {
            var n = 1002;

            var expected = 3;

            var result = CountCommas(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public long CountCommas(long n)
        {
            long result = 0;
            for (long i = 1000; i <= n; i *= 1000)
                result += n - i + 1;
            return result;
        }
    }
}
