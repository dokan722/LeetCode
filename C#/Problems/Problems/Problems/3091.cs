using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3091 : IProblem
    {
        public bool Test()
        {
            var k = 11;

            var expected = 5;

            var result = MinOperations(k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinOperations(int k)
        {
            if (k == 1)
                return 0;
            int x = (int)Math.Sqrt(k - 1);
            return Math.Min(x - 1 + (k - 1) / x, x + (k - 1) / (x + 1));
        }
    }
}
