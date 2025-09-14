using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3517 : IProblem
    {
        public bool Test()
        {
            var s = "babab";

            var expected = "abbba";

            var result = SmallestPalindrome(s);

            Console.WriteLine(result);

            return expected == result;
        }

        public string SmallestPalindrome(string s)
        {
            var n = s.Length;
            var isOdd = n % 2 == 1;
            var count = new int[26];
            foreach (var c in s)
                count[c - 'a']++;
            var middle = "";
            if (isOdd)
            {
                for (int i = 0; i < 26; ++i)
                {
                    if (count[i] % 2 == 1)
                    {
                        middle += (char)(i + 'a');
                        break;
                    }
                }
            }

            var half = new StringBuilder();
            for (int i = 0; i < 26; ++i)
            {
                half.Append(new string((char)(i + 'a'), count[i] / 2));
            }

            return half + middle + string.Join("", half.ToString().Reverse());
        }
    }
}
