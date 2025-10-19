using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1456 : IProblem
    {
        public bool Test()
        {
            var s = "abciiidef";
            var k = 3;

            var expected = 3;

            var result = MaxVowels(s, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxVowels(string s, int k)
        {
            var n = s.Length;
            var curr = 0;
            for (int i = 0; i < k; ++i)
            {
                if (IsVowel(s[i]))
                    curr++;
            }

            var result = curr;
            for (int i = k; i < n; ++i)
            {
                curr += IsVowel(s[i]) ? 1 : 0;
                curr -= IsVowel(s[i - k]) ? 1 : 0;
                result = Math.Max(curr, result);
            }

            return result;
        }

        private bool IsVowel(char c)
        {
            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                return true;
            return false;
        }
    }
}
