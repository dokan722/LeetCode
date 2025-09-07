using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1347 : IProblem
    {
        public bool Test()
        {
            var s = "leetcode";
            var t = "practice";

            var expected = 5;

            var result = MinSteps(s, t);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinSteps(string s, string t)
        {
            var counts = new int[26];
            for (int i = 0; i < s.Length; i++)
            {
                counts[s[i] - 'a']++;
                counts[t[i] - 'a']--;
            }

            var result = 0;
            foreach (var count in counts)
                if (count > 0)
                    result += count;

            return result;
        }
    }
}
