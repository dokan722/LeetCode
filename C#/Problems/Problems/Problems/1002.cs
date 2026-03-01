using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1002 : IProblem
    {
        public bool Test()
        {
            var words = new[] { "bella", "label", "roller" };

            var expected = new[] { "e", "l", "l" };

            var result = CommonChars(words).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public IList<string> CommonChars(string[] words)
        {
            var n = words.Length;
            var counts = new int[26];
            foreach (var c in words[0])
                counts[c - 'a']++;

            for (int i = 1; i < n; ++i)
            {
                var curCounts = new int[26];
                foreach (var c in words[i])
                    curCounts[c - 'a']++;
                for (int j = 0; j < 26; ++j)
                    counts[j] = Math.Min(counts[j], curCounts[j]);
            }

            var result = new List<string>();
            for (int i = 0; i < 26; ++i)
            {
                for (int j = 0; j < counts[i]; ++j)
                {
                    result.Add(((char)('a' + i)).ToString());
                }
            }

            return result;
        }
    }
}
