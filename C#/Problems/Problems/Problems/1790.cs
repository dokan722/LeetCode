using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1790 : IProblem
    {
        public bool Test()
        {
            var s1 = "bank";
            var s2 = "kanb";

            var expected = true;

            var result = AreAlmostEqual(s1, s2);

            return expected == result;
        }

        public bool AreAlmostEqual(string s1, string s2)
        {
            var n = s1.Length;
            var diffs = new int[2];
            var numDiffs = 0;
            for (int i = 0; i < n; i++)
            {
                if (s1[i] != s2[i])
                {
                    if (numDiffs == 2)
                        return false;
                    diffs[numDiffs] = i;
                    numDiffs++;
                }
            }

            return s1[diffs[0]] == s2[diffs[1]] && s1[diffs[1]] == s2[diffs[0]];
        }
    }
}
