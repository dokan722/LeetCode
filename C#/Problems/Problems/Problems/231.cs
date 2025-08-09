using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _231 : IProblem
    {
        public bool Test()
        {
            var n = 16;

            var expected = true;

            var result = IsPowerOfTwo(n);

            return result == expected;
        }

        public bool IsPowerOfTwo(int n)
        {
            if (n <= 0)
                return false;

            while (n > 1)
            {
                var mod = n % 2;
                if (mod == 1)
                    return false;
                n >>= 1;
            }

            return true;
        }
    }
}
