using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _5 : IProblem
    {
        public bool Test()
        {
            var n = "cbbd";
           

            var expected = "bb";

            var result = LongestPalindrome(n);

            Console.WriteLine(result);

            return expected == result;
        }

        public string LongestPalindrome(string s)
        {
            string longest = s[0].ToString();

            for (int i = 0; i < s.Length - 1; i++)
            {
                var odd = CheckOdd(s, i);
                var oddSub = s.Substring(i - odd + 1, 2 * odd - 1);
                if (oddSub.Length > longest.Length)
                    longest = oddSub;
                var even = CheckEven(s, i);
                var evenSub = s.Substring(i - even + 1, 2 * even);
                if (evenSub.Length > longest.Length)
                    longest = evenSub;
            }
            return longest;
        }

        private int CheckOdd(string s, int i)
        {
            var side = 1;
            while (i + side < s.Length && i - side >= 0)
            {
                
                if (s[i + side] != s[i - side])
                    return side;
                side++;
            }

            return side;
        }

        private int CheckEven(string s, int i)
        {
            if (s[i] != s[i + 1])
                return 0;
            var side = 1;

            while (i + side + 1 < s.Length && i - side >= 0)
            {
                if (s[i + side + 1] != s[i - side])
                    return side;
                side++;
            }

            return side;
        }
    }
}
