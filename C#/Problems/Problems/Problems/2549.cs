using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2549 : IProblem
    {
        public bool Test()
        {
            var n = 5;

            var expected = 4;

            var result = DistinctIntegers(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int DistinctIntegers(int n)
        {
            return n == 1 ? 1 : n - 1;
        }
    }
}
