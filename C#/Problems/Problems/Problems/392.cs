using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _392 : IProblem
    {
        public bool Test()
        {
            var s = "abc";
            var t = "ahbgdc";

            var expected = true;

            var result = IsSubsequence(s, t);

            return result == expected;
        }

        public bool IsSubsequence(string s, string t)
        {
            var n = s.Length;
            var m = t.Length;
            var j = 0;
            for (int i = 0; i < n; ++i)
            {
                while (j < m && s[i] != t[j])
                    j++;
                if (j == m)
                    return false;
                j++;
            }

            return true;
        }
    }
}
