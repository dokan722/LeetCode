using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1780 : IProblem
    {
        public bool Test()
        {
            var n = 91;

            var expected = true;

            var result = CheckPowersOfThree(n);

            return result == expected;
        }

        public bool CheckPowersOfThree(int n)
        {
            int curr = 1;
            while (curr <= n)
                curr *= 3;

            while (n > 0)
            {
                if (n >= curr)
                    n -= curr;
                if (n >= curr)
                    return false;
                curr /= 3;
            }

            return true;
        }
    }
}
