using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1551 : IProblem
    {
        public bool Test()
        {
            var n = 3;

            var expected = 2;

            var result = MinOperations(n);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinOperations(int n)
        {
            var half = n / 2;
            if (n % 2 == 1)
                return half * (half + 1);
            return n * (n - 1) / 2 - half * (half - 1);
        }
    }
}
