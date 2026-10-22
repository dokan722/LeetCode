using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1941 : IProblem
    {
        public bool Test()
        {
            var s = "abacbc";

            var expected = true;

            var result = AreOccurrencesEqual(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public bool AreOccurrencesEqual(string s)
        {
            var counts = new int[26];
            foreach (var c in s)
                counts[c - 'a']++;
            var eq = -1;
            for (int i = 0; i < 26; ++i)
            {
                if (counts[i] == 0)
                    continue;
                if (eq == -1)
                    eq = counts[i];
                else if (counts[i] != eq)
                    return false;
            }

            return true;
        }
    }
}
