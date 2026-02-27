using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _859 : IProblem
    {
        public bool Test()
        {
            var s = "ab";
            var goal = "ba";

            var expected = true;

            var result = BuddyStrings(s, goal);

            return result == expected;
        }

        public bool BuddyStrings(string s, string goal)
        {
            var n = s.Length;
            if (n != goal.Length)
                return false;
            var diff = -1;
            var swapped = false;
            var multi = false;
            var present = new bool[26];
            for (int i = 0; i < n; ++i)
            {
                if (!multi)
                {
                    var id = s[i] - 'a';
                    if (present[id])
                        multi = true;
                    else
                        present[id] = true;
                }
                if (s[i] != goal[i])
                {
                    if (swapped)
                        return false;
                    if (diff == -1)
                        diff = i;
                    else
                    {
                        if (s[i] != goal[diff] || s[diff] != goal[i])
                            return false;
                        swapped = true;
                    }

                }
            }

            return swapped || (diff == -1 && multi);
        }
    }
}
