using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3461 : IProblem
    {
        public bool Test()
        {
            var s = "3902";

            var expected = true;

            var result = HasSameDigits(s);

            return expected == result;
        }

        public bool HasSameDigits(string s)
        {
            while (s.Length > 2)
            {
                var sb = new StringBuilder();
                for (int i = 1; i < s.Length; i++)
                {
                    sb.Append((char)('0' + (s[i - 1] + s[i] - 2 * '0') % 10));
                }

                s = sb.ToString();
            }

            return s[0] == s[1];
        }
    }
}
