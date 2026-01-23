using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2186 : IProblem
    {
        public bool Test()
        {
            var s = "leetcode";
            var t = "coats";

            var expected = 7;

            var result = MinSteps(s, t);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinSteps(string s, string t)
        {
            var counts = new int[26];
            foreach (var c in s)
                counts[c - 'a']++;
            foreach (var c in t)
                counts[c - 'a']--;
            var result = 0;
            for (int i = 0; i < 26; ++i)
                result += Math.Abs(counts[i]);
            return result;
        }
    }
}
