using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3848 : IProblem
    {
        public bool Test()
        {
            var n = 145;

            var expected = true;

            var result = IsDigitorialPermutation(n);

            return expected == result;
        }

        public bool IsDigitorialPermutation(int n)
        {
            var factorials = new int[] { 1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880 };
            var fs = 0;
            var counts = new int[10];
            while (n > 0)
            {
                var digit = n % 10;
                fs += factorials[digit];
                counts[digit]++;
                n /= 10;
            }
            while (fs > 0)
            {
                counts[fs % 10]--;
                fs /= 10;
            }
            for (int i = 0; i < 10; ++i)
            {
                if (counts[i] != 0)
                    return false;
            }

            return true;
        }
    }
}
