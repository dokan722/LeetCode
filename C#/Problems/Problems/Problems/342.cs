using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _342 : IProblem
    {
        public bool Test()
        {
            var n = 16;

            var expected = true;

            var result = IsPowerOfFour(n);

            return expected == result;
        }

        public bool IsPowerOfFour(int n)
        {
            if (n < 1)
                return false;
            while (n > 1)
            {
                if (n % 4 != 0)
                    return false;
                n /= 4;
            }

            return true;
        }
    }
}
