using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2839 : IProblem
    {
        public bool Test()
        {
            var s1 = "abcd";
            var s2 = "cdab";

            var expected = true;

            var result = CanBeEqual(s1, s2);

            return result == expected;
        }
        public bool CanBeEqual(string s1, string s2)
        {
            var n = s1.Length;
            for (int i = 0; i < n - 2; ++i)
            {
                if ((s1[i] != s2[i] || s1[i + 2] != s2[i + 2]) && (s1[i] != s2[i + 2] || s1[i + 2] != s2[i]))
                    return false;
            }

            return true;
        }

    }
}
