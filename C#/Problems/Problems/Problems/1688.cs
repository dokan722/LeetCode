using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1688 : IProblem
    {
        public bool Test()
        {
            var n = 7;

            var expected = 6;

            var result = NumberOfMatches(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumberOfMatches(int n)
        {
            var result = 0;
            while (n > 1)
            {
                if (n % 2 == 0)
                    result += (n /= 2);
                else
                {
                    result += (n - 1) / 2;
                    n = (n - 1) / 2 + 1;
                }
            }

            return result;
        }
    }
}
