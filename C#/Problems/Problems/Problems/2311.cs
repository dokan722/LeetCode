using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2311 : IProblem
    {
        public bool Test()
        {
            var s = "1001010";

            var k = 5;

            var expected = 5;

            var result = LongestSubsequence(s, k);

            return result == expected;
        }


        public int LongestSubsequence(string s, int k)
        {
            long factor = 1;
            long num = 0;
            int i = s.Length - 1;
            var found = false;
            var lastOne = s.Length;
            for (; i >= 0; i--)
            {
                if (s[i] == '1')
                {
                    if (num + factor <= k)
                    {
                        num += factor;
                        lastOne = i;
                        found = true;
                    }
                    else
                        break;
                }

                if (factor > int.MaxValue)
                    break;
                factor *= 2;
            }

            if (i == -1)
                return s.Length;
            var zeros = 0;
            if (!found)
            {
                foreach (var v in s)
                    if (v == '0')
                        zeros++;
                return zeros;
            }
            foreach (var v in s.Substring(0, lastOne))
                if (v == '0')
                    zeros++;
            

            return s.Length - lastOne + zeros;
        }
    }
}
