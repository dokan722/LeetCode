using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1611 : IProblem
    {
        public bool Test()
        {
            var n = 6;

            var expected = 4;

            var result = MinimumOneBitOperations(n);

            Console.WriteLine(result);

            return result == expected;
        }
        public int MinimumOneBitOperations(int n)
        {
            if (n == 1)
                return 1;

            int k = 0;
            int curr = 1;
            while (curr * 2 <= n)
            {
                curr *= 2;
                k++;
            }

            return (1 << (k + 1)) - 1 - MinimumOneBitOperations(n ^ curr);
        }
    }
}
