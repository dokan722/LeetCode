using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2413 : IProblem
    {
        public bool Test()
        {
            var n = 5;

            var expected = 10;

            var result = SmallestEvenMultiple(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SmallestEvenMultiple(int n)
        {
            if (n % 2 == 0)
                return n;
            return 2 * n;
        }
    }
}
