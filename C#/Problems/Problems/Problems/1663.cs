using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1663 : IProblem
    {
        public bool Test()
        {
            var n = 5;
            var k = 73;

            var expected = "aaszz";

            var result = GetSmallestString(n, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public string GetSmallestString(int n, int k)
        {
            var result = new char[n];
            k -= n;
            for (int i = n - 1; i >= 0; --i)
            {
                if (k > 25)
                {
                    result[i] = 'z';
                    k -= 25;
                }
                else if (k != 0)
                {
                    result[i] = (char)('a' + k);
                    k = 0;
                }
                else
                    result[i] = 'a';
            }

            return new string(result);
        }
    }
}
