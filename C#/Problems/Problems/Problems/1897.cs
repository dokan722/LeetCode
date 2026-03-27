using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1897 : IProblem
    {
        public bool Test()
        {
            var words = new[] { "abc", "aabc", "bc" };

            var expected = true;

            var result = MakeEqual(words);

            return result == expected;
        }
        public bool MakeEqual(string[] words)
        {
            var n = words.Length;
            var counts = new int[26];
            foreach (var word in words)
            {
                foreach (var c in word)
                    counts[c - 'a']++;
            }
            for (int i = 0; i < 26; ++i)
            {
                if (counts[i] % n != 0)
                    return false;
            }

            return true;
        }

    }
}
