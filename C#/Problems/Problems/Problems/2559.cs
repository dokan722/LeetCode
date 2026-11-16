using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2559 : IProblem
    {
        public bool Test()
        {
            string[] words = new string[] { "aba", "bcb", "ece", "aa", "e" };
            int[][] queries = new int[][] { new int[] { 0, 2 }, new int[] { 1, 4 }, new int[] { 1, 1 } };

            var expected = new[] { 2, 3, 0 };

            var result = VowelStrings(words, queries);

            Utils.Print1DArray(expected);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] VowelStrings(string[] words, int[][] queries)
        {
            var n = words.Length;
            var m = queries.Length;
            var cnt = new int[n + 1];
            for (int i = 1; i <= n; ++i)
            {
                cnt[i] = cnt[i - 1];
                var word = words[i - 1];
                var f = word[0];
                var l = word[word.Length - 1];
                if ((f == 'a' || f == 'e' || f == 'i' || f == 'o' || f == 'u') && (l == 'a' || l == 'e' || l == 'i' || l == 'o' || l == 'u'))
                    cnt[i]++;
            }

            var result = new int[m];
            for (int i = 0; i < m; ++i)
            {
                result[i] = cnt[queries[i][1] + 1] - cnt[queries[i][0]];
            }

            return result;
        }
    }
}
