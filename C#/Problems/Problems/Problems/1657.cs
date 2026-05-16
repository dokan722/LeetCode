using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1657 : IProblem
    {
        public bool Test()
        {
            var word1 = "abc";
            var word2 = "bca";

            var expected = true;

            var result = CloseStrings(word1, word2);

            return result == expected;
        }

        public bool CloseStrings(string word1, string word2)
        {
            var n = word1.Length;
            if (n != word2.Length)
                return false;
            var counts1 = new int[26];
            var counts2 = new int[26];
            for (int i = 0; i < n; ++i)
            {
                counts1[word1[i] - 'a']++;
                counts2[word2[i] - 'a']++;
            }
            for (int i = 0; i < 26; ++i)
            {
                if (Math.Min(counts1[i], counts2[i]) == 0 && Math.Max(counts1[i], counts2[i]) != 0)
                    return false;
            }
            Array.Sort(counts1);
            Array.Sort(counts2);
            for (int i = 0; i < 26; ++i)
            {
                if (counts1[i] != counts2[i])
                    return false;
            }

            return true;
        }
    }
}
