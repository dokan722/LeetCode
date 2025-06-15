using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1545 : IProblem
    {
        public bool Test()
        {
            var n = 3;

            var k = 7;

            var expected = '1';

            var result = FindKthBit(n, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public char FindKthBit(int n, int k)
        {
            if (n == 1)
                return '0';

            var sLen = (1 << n);
            var half = sLen / 2;

            if (k < half)
                return FindKthBit(n - 1, k);

            if (k == sLen / 2)
                return '1';

            return FindKthBit(n - 1, sLen - k) == '1' ? '0' : '1';
        }
    }
}
