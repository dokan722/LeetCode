using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _115 : IProblem
    {
        public bool Test()
        {
            var s = "rabbbit";
            var t = "rabbit";

            var expected = 3;

            var result = NumDistinct(s, t);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumDistinct(string s, string t)
        {
            var n = s.Length;
            var m = t.Length;
            if (n < m)
                return 0;
            var dp = new int[m];
            foreach (var c in s)
            {
                for (int i = m - 1; i > 0; --i)
                {
                    if (t[i] == c)
                        dp[i] += dp[i - 1];
                }
                if (c == t[0])
                    dp[0]++;
            }

            return dp[m - 1];
        }
    }
}
