using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1759 : IProblem
    {
        public bool Test()
        {
            var s = "abbcccaa";

            var expected = 13;

            var result = CountHomogenous(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountHomogenous(string s)
        {
            var n = s.Length;
            var first = 0;
            long result = 0;
            var mod = 1000000007;
            for (int i = 0; i < n; ++i)
            {
                if (s[i] != s[first])
                {
                    long l = i - first;
                    result = (result + l * (l + 1) / 2) % mod;
                    first = i;
                }
            }
            long ls = n - first;
            result = (result + ls * (ls + 1) / 2) % mod;
            return (int)result;
        }
    }
}
