using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3370 : IProblem
    {
        public bool Test()
        {
            var n = 5;

            var expected = 7;

            var result = SmallestNumber(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SmallestNumber(int n)
        {
            var val = 2;
            while (val <= n)
                val <<= 1;

            return val - 1;
        }
    }
}
