using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3982 : IProblem
    {
        public bool Test()
        {
            var s = "cat";
            var t = "chat";

            var expected = true;

            var result = CanMakeSubsequence(s, t);

            return result == expected;
        }

        public bool CanMakeSubsequence(string s, string t)
        {
            var n = t.Length;
            var m = s.Length;
            if (m > n)
                return false;
            var suf = new int[n];
            var c = 0;
            var j = m - 1;
            for (int i = n - 1; i >= 0; --i)
            {
                suf[i] = c;
                if (j > 0 && t[i] == s[j])
                {
                    c++;
                    j--;
                }
            }
            j = 0;
            var changed = false;
            for (int i = 0; i < n && j < m; ++i)
            {
                if (s[j] == t[i])
                    j++;
                else if (!changed && suf[i] >= m - j - 1)
                {
                    j++;
                    changed = true;
                }
            }

            return j == m;
        }
    }
}
