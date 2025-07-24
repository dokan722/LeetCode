using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2322 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 5, 5, 4, 11 };
            var edges = new[] { new[] { 0, 1 }, new[] { 1, 2 }, new[] { 1, 3 }, new[] { 3, 4 } };

            var expected = 9;

            var result = MinimumScore(nums, edges);

            Console.WriteLine(result);

            return expected == result;
        }

        private int[] _xored;
        private HashSet<int>[] _children;
        private List<int>[] _tree;

        private void xorDfs(int node, int parent, int[] nums)
        {
            _xored[node] = nums[node];
            _children[node].Add(node);

            foreach (int child in _tree[node])
            {
                if (child != parent)
                {
                    xorDfs(child, node, nums);
                    _xored[node] ^= _xored[child];
                    foreach (var grandchild in _children[child])
                    {
                        _children[node].Add(grandchild);
                    }
                }
            }
        }

        public int MinimumScore(int[] nums, int[][] edges)
        {
            int n = nums.Length;
            _tree = new List<int>[n];
            _xored = new int[n];
            _children = new HashSet<int>[n];
            for (int i = 0; i < n; i++)
            {
                _tree[i] = new List<int>();
                _children[i] = new HashSet<int>();
            }

            foreach (var edge in edges)
            {
                _tree[edge[0]].Add(edge[1]);
                _tree[edge[1]].Add(edge[0]);
            }

            xorDfs(0, -1, nums);

            int total = _xored[0];
            int result = int.MaxValue;

            for (int i = 1; i < n; ++i)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    int xor_i = _xored[i];
                    int xor_j = _xored[j];
                    int val1, val2, val3;

                    if (_children[i].Contains(j))
                    {
                        val1 = xor_j;
                        val2 = xor_i ^ xor_j;
                        val3 = total ^ xor_i;
                    }
                    else if (_children[j].Contains(i))
                    {
                        val1 = xor_i;
                        val2 = xor_j ^ xor_i;
                        val3 = total ^ xor_j;
                    }
                    else
                    { 
                        val1 = xor_i;
                        val2 = xor_j;
                        val3 = total ^ xor_i ^ xor_j;
                    }

                    var score = Math.Max( val1, Math.Max(val2, val3)) - Math.Min( val1, Math.Min(val2, val3));
                    if (score < result)
                        result = score;
                }
            }

            return result;
        }
    }
}
