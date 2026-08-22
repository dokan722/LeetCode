using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _916 : IProblem
    {
        public bool Test()
        {
            var words1 = new[] { "amazon", "apple", "facebook", "google", "leetcode" };
            var words2 = new[] { "e", "o" };

            var expected = new[] { "facebook", "google", "leetcode" };

            var result = WordSubsets(words1, words2);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<string> WordSubsets(string[] words1, string[] words2)
        {
            var n = words1.Length;
            var m = words2.Length;
            var counts1 = new int[n][];
            var counts2 = new int[26];
            for (int i = 0; i < n; ++i)
            {
                counts1[i] = new int[26];
                foreach (var c in words1[i])
                    counts1[i][c - 'a']++;
            }
            for (int i = 0; i < m; ++i)
            {
                var counts = new int[26];
                foreach (var c in words2[i])
                    counts[c - 'a']++;
                for (int j = 0; j < 26; ++j)
                    counts2[j] = Math.Max(counts2[j], counts[j]);
            }
            var result = new List<string>();
            for (int i = 0; i < n; ++i)
            {
                var fit = true;
                for (int j = 0; j < 26; ++j)
                {
                    if (counts2[j] > counts1[i][j])
                    {
                        fit = false;
                        break;
                    }
                }
                if (fit)
                    result.Add(words1[i]);
            }

            return result;
        }
    }
}
