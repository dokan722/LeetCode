using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3302 : IProblem
    {
        public bool Test()
        {
            var word1 = "vbcca";
            var word2 = "abc";

            var expected = new[] { 0, 1, 2 };

            var result = ValidSequence(word1, word2);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] ValidSequence(string word1, string word2)
        {
            var n = word1.Length;
            var m = word2.Length;
            var suf = new int[n];
            var c = 0;
            var j = m - 1;
            for (int i = n - 1; i >= 0; --i)
            {
                suf[i] = c;
                if (j > 0 && word1[i] == word2[j])
                {
                    c++;
                    j--;
                }
            }
            var result = new int[m];
            j = 0;
            var changed = false;
            for (int i = 0; i < n && j < m; ++i)
            {
                if (word2[j] == word1[i])
                {
                    result[j] = i;
                    j++;
                }
                else if (!changed && suf[i] >= m - j - 1)
                {
                    result[j] = i;
                    j++;
                    changed = true;
                }
            }

            return j == m ? result : new int[] { };
        }
    }
}
