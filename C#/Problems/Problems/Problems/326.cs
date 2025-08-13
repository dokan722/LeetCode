using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _326 : IProblem
    {
        public bool Test()
        {
            var n = 27;

            var expected = true;

            var result = IsPowerOfThree(n);

            return expected == result;
        }

        public bool IsPowerOfThree(int n)
        {
            if (n < 1)
                return false;
            while (n > 1)
            {
                if (n % 3 != 0)
                    return false;
                n /= 3;
            }

            return true;
        }
    }
}
