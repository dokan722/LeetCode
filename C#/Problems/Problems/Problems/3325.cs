using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3325 : IProblem
    {
        public bool Test()
        {
            var s = "abacb";
            var k = 2;

            var expected = 4;

            var result = NumberOfSubstrings(s, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public int NumberOfSubstrings(string s, int k)
        {
            var n = s.Length;
            int i = -1;
            int j = -1;
            int result = 0;
            var maxLetter = 0;
            var counts = new int[26];
            while (i < n - 1)
            {
                while (i < n - 1 && counts[maxLetter] < k)
                {
                    i++;
                    counts[s[i] - 'a']++;
                    if (counts[s[i] - 'a'] > counts[maxLetter])
                        maxLetter = s[i] - 'a';
                }

                while (j < n - 1 && counts[maxLetter] >= k)
                {
                    result += (n - i);
                    j++;
                    counts[s[j] - 'a']--;
                }
            }

            return result;
        }
    }
}
