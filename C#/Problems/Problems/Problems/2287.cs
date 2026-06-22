using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    // SAME AS 1189
    public class _2287 : IProblem
    {
        public bool Test()
        {
            var s = "ilovecodingonleetcode";
            var target = "code";

            var expected = 2;

            var result = RearrangeCharacters(s, target);

            Console.WriteLine(result);

            return result == expected;
        }

        public int RearrangeCharacters(string s, string target)
        {
            var counts = new int[26];
            var countsT = new int[26];
            foreach (var c in s)
                counts[c - 'a']++;
            foreach (var c in target)
                countsT[c - 'a']++;
            var result = int.MaxValue;
            for (int i = 0; i < 26; ++i)
                if (countsT[i] != 0)
                    result = Math.Min(result, counts[i] / countsT[i]);
            return result;
        }
    }
}
