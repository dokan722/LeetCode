using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1816 : IProblem
    {
        public bool Test()
        {
            var s = "chopper is not a tanuki";
            var k = 5;

            var expected = "chopper is not a tanuki";

            var result  = TruncateSentence(s, k);

            Console.WriteLine(expected);

            return result == expected;
        }

        public string TruncateSentence(string s, int k)
        {
            var n = s.Length;
            var i = 0;
            var cnt = 0;
            while (i < n && cnt < k)
            {
                if (s[i] == ' ')
                    cnt++;
                ++i;
            }
            if (i == n)
                return s;
            return s.Substring(0, i - 1);
        }
    }
}
