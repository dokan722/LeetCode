using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3043 : IProblem
    {
        public bool Test()
        {
            var arr1 = new[] { 1, 10, 100 };
            var arr2 = new[] { 1000 };

            var expected = 3;

            var result = LongestCommonPrefix(arr1, arr2);

            Console.WriteLine(result);

            return result == expected;
        }

        private class TrieNode
        {
            public TrieNode?[] Children = new TrieNode[10];
        }

        public int LongestCommonPrefix(int[] arr1, int[] arr2)
        {
            var root = new TrieNode();
            foreach (var num in arr1)
            {
                var s = num.ToString();
                var cur = root;
                foreach (var c in s)
                {
                    var digit = c - '0';
                    if (cur.Children[digit] == null)
                        cur.Children[digit] = new TrieNode();
                    cur = cur.Children[digit];
                }
            }
            var result = 0;
            foreach (var num in arr2)
            {
                var s = num.ToString();
                var n = s.Length;
                var i = 1;
                var cur = root.Children[s[0] - '0'];
                while (i < s.Length && cur != null)
                {
                    cur = cur.Children[s[i] - '0'];
                    i++;
                }
                result = Math.Max(result, i - (cur == null ? 1 : 0));
            }

            return result;
        }
    }
}
