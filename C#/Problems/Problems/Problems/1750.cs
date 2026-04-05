using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1750 : IProblem
    {
        public bool Test()
        {
            var s = "ca";

            var expected = 2;

            var result = MinimumLength(s);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinimumLength(string s)
        {
            var n = s.Length;
            var l = 0;
            var r = n - 1;
            while (l < r && l < n && r >= 0 && s[l] == s[r])
            {
                var c = s[l];
                while (l < n && s[l] == c)
                    l++;
                while (r >= 0 && s[r] == c)
                    r--;
            }

            if (l < r)
                return r - l + 1;
            return l == r ? 1 : 0;
        }
    }
}
