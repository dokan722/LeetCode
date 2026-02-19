using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _696 : IProblem
    {
        public bool Test()
        {
            var s = "00110011";

            var expected = 6;

            var result = CountBinarySubstrings(s);

            Console.WriteLine(result);

            return result == expected;
        }
        public int CountBinarySubstrings(string s)
        {
            var n = s.Length;
            var last = 0;
            while (last < n - 1 && s[last] == s[last + 1])
                last++;
            var result = 0;
            var prev = last + 1;
            for (int i = last + 1; i < n - 1; ++i)
            {
                if (s[i] != s[i + 1])
                {
                    var curr = i - last;
                    result += Math.Min(curr, prev);
                    last = i;
                    prev = curr;
                }
            }
            result += Math.Min(prev, n - last - 1);

            return result;
        }

    }
}
