using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3365 : IProblem
    {
        public bool Test()
        {
            var s = "abcd";
            var t = "cdab";
            var k = 2;

            var expected = true;

            var result = IsPossibleToRearrange(s, t, k);

            return result == expected;
        }

        public bool IsPossibleToRearrange(string s, string t, int k)
        {
            var n = s.Length;
            if (n == k)
                return true;
            var fLen = n / k;
            var target = new Dictionary<string, int>();
            for (int i = 0; i < k; ++i)
            {
                var f = t.Substring(i * fLen, fLen);
                if (target.ContainsKey(f))
                    target[f]++;
                else
                    target[f] = 1;
            }
            for (int i = 0; i < k; ++i)
            {
                var f = s.Substring(i * fLen, fLen);
                if (target.ContainsKey(f))
                    target[f]--;
                else
                    target[f] = -1;
                if (target[f] < 0)
                    return false;
            }
            foreach (var e in target)
            {
                if (e.Value != 0)
                    return false;
            }
            return true;
        }
    }
}
