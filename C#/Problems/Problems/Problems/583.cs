using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _583 : IProblem
    {
        public bool Test()
        {
            var word1 = "sea";
            var word2 = "eat";

            var expected = 2;

            var result = MinDistance(word1, word2);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinDistance(string word1, string word2)
        {
            var n = word1.Length;
            var m = word2.Length;
            var dp = new int[n][];
            for (int i = 0; i < n; ++i)
                dp[i] = Enumerable.Repeat(-1, m).ToArray();
            return MinDistRec(dp, word1, word2, 0, 0);
        }

        private int MinDistRec(int[][] dp, string word1, string word2, int i, int j)
        {
            if (i >= word1.Length)
                return word2.Length - j;
            if (j >= word2.Length)
                return word1.Length - i;
            if (dp[i][j] != -1)
                return dp[i][j];
            int result;
            if (word1[i] == word2[j])
                result =  MinDistRec(dp, word1, word2, i + 1, j + 1);
            else
                result = Math.Min(MinDistRec(dp, word1, word2, i + 1, j) + 1, MinDistRec(dp, word1, word2, i, j + 1) + 1);
            dp[i][j] = result;

            return result;
        }
    }
}
