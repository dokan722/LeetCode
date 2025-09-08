using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1317 : IProblem
    {
        public bool Test()
        {
            var n = 2137;
            var result = GetNoZeroIntegers(n);

            return result[0] + result[1] == n;
        }

        public int[] GetNoZeroIntegers(int n)
        {
            var result = new int[2];
            var mult = 1;
            while (n > 1)
            {
                var curr = n % 10;
                var rest = n / 10;
                if (curr > 1)
                {
                    result[0] += 1 * mult;
                    result[1] += (curr - 1) * mult;
                }
                else
                {
                    curr += 10;
                    rest -= 1;
                    var part = curr / 2;
                    result[0] += part * mult;
                    result[1] += (curr - part) * mult;
                }

                n = rest;
                mult *= 10;
            }

            if (n == 1)
                result[0] += mult;

            return result;
        }
    }
}
