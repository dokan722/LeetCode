using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2472 : IProblem
    {
        public bool Test()
        {
            var s = "abaccdbbd";
            var k = 3;

            var expected = 2;

            var result = MaxPalindromes(s, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxPalindromes(string s, int k)
        {
            var n = s.Length;
            if (k == 1)
                return n;
            var result = 0;
            var last = -1;
            for (int i = k; i < n; ++i)
            {
                if (IsPalindrome(s, i - k, i - 1))
                {
                    last = i - 1;
                    result += 1;
                    i += k - 1;

                }
                else if (IsPalindrome(s, i - k, i))
                {
                    last = i;
                    result += 1;
                    i += k;
                }
            }
            if (last < n - k && IsPalindrome(s, n - k, n - 1))
                result++;
            return result;
        }

        private bool IsPalindrome(string s, int i, int j)
        {
            while (i < j)
            {
                if (s[i++] != s[j--])
                    return false;
            }

            return true;
        }
    }
}
