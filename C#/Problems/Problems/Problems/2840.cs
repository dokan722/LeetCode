using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2840 : IProblem
    {
        public bool Test()
        {
            var s1 = "abcdba";
            var s2 = "cabdab";

            var expected = true;

            var result = CheckStrings(s1, s2);

            return expected == result;
        }

        public bool CheckStrings(string s1, string s2)
        {
            var n = s1.Length;
            var countsEven1 = new int[26];
            var countsOdd1 = new int[26];
            var countsEven2 = new int[26];
            var countsOdd2 = new int[26];
            for (int i = 0; i < n; ++i)
            {
                if (i % 2 == 0)
                {
                    countsEven1[s1[i] - 'a']++;
                    countsEven2[s2[i] - 'a']++;
                }
                else
                {
                    countsOdd1[s1[i] - 'a']++;
                    countsOdd2[s2[i] - 'a']++;
                }
            }

            for (int i = 0; i < 26; ++i)
            {
                if (countsEven1[i] != countsEven2[i] || countsOdd1[i] != countsOdd2[i])
                    return false;
            }

            return true;
        }
    }
}
