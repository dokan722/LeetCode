using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3093 : IProblem
    {
        public bool Test()
        {
            var wordsContainer = new[] { "abcd", "bcd", "xbcd" };
            var wordsQuery = new[] {"cd", "bcd", "xyz" };

            var expected = new[] { 1, 1, 1 };

            var result = StringIndices(wordsContainer, wordsQuery);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        private class Trie
        {
            public Trie[] Children { get; }
            public int Best { get; set; }
            public Trie(int value)
            {
                Children = new Trie[26];
                Best = value;
            }
        }

        public int[] StringIndices(string[] wordsContainer, string[] wordsQuery)
        {
            var n = wordsContainer.Length;
            var root = new Trie(0);
            for (int i = 0; i < n; ++i)
            {
                var w = wordsContainer[i];
                var cur = root;
                var l = w.Length;
                for (int j = l - 1; j >= 0; --j)
                {
                    var id = w[j] - 'a';
                    if (cur.Children[id] == null)
                        cur.Children[id] = new Trie(i);
                    if (wordsContainer[cur.Best].Length > l)
                        cur.Best = i;
                    cur = cur.Children[id];
                }
                if (cur != null && wordsContainer[cur.Best].Length > l)
                    cur.Best = i;
            }
            var m = wordsQuery.Length;
            var result = new int[m];
            for (int i = 0; i < m; ++i)
            {
                var cur = root;
                var j = wordsQuery[i].Length - 1;
                while (j >= 0 && cur.Children[wordsQuery[i][j] - 'a'] != null)
                {
                    cur = cur.Children[wordsQuery[i][j] - 'a'];
                    j--;
                }
                result[i] = cur.Best;
            }

            return result;
        }
    }
}
