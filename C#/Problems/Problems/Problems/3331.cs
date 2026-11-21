using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3331 : IProblem
    {
        public bool Test()
        {
            var parent = new[] { -1, 0, 0, 1, 1, 1 };
            var s = "abaabc";

            var expected = new[] { 6, 3, 1, 1, 1, 1 };

            var result = FindSubtreeSizes(parent, s);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] FindSubtreeSizes(int[] parent, string s)
        {
            var n = parent.Length;
            var children = new List<int>[n];
            var newChildren = new List<int>[n];
            for (int i = 0; i < n; ++i)
            {
                children[i] = new List<int>();
                newChildren[i] = new List<int>();
            }
            for (int i = 1; i < n; ++i)
                children[parent[i]].Add(i);
            var ancestors = Enumerable.Repeat(-1, 26).ToArray();
            UpdateSubTree(0, children, newChildren, ancestors, s);
            var result = new int[n];
            CountChildren(0, newChildren, result);

            return result;
        }

        private void UpdateSubTree(int id, List<int>[] children, List<int>[] newChildren, int[] ancestors, string s)
        {
            var c = s[id] - 'a';
            var prevAncestor = ancestors[c];
            ancestors[c] = id;

            foreach (var ch in children[id])
            {
                var chc = s[ch] - 'a';
                if (ancestors[chc] != -1)
                    newChildren[ancestors[chc]].Add(ch);
                else
                    newChildren[id].Add(ch);
                UpdateSubTree(ch, children, newChildren, ancestors, s);
            }

            ancestors[c] = prevAncestor;
        }

        private void CountChildren(int id, List<int>[] children, int[] result)
        {
            var count = 1;
            foreach (var ch in children[id])
            {
                CountChildren(ch, children, result);
                count += result[ch];
            }
            result[id] = count;
        }
    }
}
