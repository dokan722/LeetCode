using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1358 : IProblem
    {
        public bool Test()
        {
            var s = "abcabc";
            var expected = 10;

            var result = NumberOfSubstrings(s);

            return expected == result;
        }

        public int NumberOfSubstrings(string s)
        {
            var left = 0;
            var counts = new int[3];
            var result = 0;
            for (var right = 0; right < s.Length; right++)
            {
                counts[s[right] - 'a']++;

                while (counts[0] > 0 && counts[1] > 0 && counts[2] > 0)
                {
                    result += s.Length - right;
                    counts[s[left] - 'a']--;
                    left++;
                }
            }

            return result;
        }
    }
}
