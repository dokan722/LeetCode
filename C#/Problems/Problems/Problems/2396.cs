using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2396 :IProblem
    {
        public bool Test()
        {
            var n = 4;


            var expected = false;

            var result = IsStrictlyPalindromic(n);

            Console.WriteLine(result);

            return expected == result;
        }

        // DOA
        //public bool IsStrictlyPalindromic(int n)
        //{
        //    return false;
        //}

        public bool IsStrictlyPalindromic(int n)
        {
            for (int i = 2; i < n - 1; ++i)
            {
                if (!IsPalindrome(ConvertToBaseReversed(n, i)))
                    return false;
            }

            return true;
        }

        private bool IsPalindrome(string s)
        {
            for (int i = 0; i < s.Length / 2; ++i)
            {
                if (s[i] != s[s.Length - i - 1])
                    return false;
            }

            return true;
        }

        private string ConvertToBaseReversed(int n, int b)
        {
            var result = new StringBuilder();
            while (n > 0)
            {
                var next = n % b;
                result.Append(next);
                n = n / b;
            }

            return result.ToString();
        }
    }
}
