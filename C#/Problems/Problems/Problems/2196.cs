using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2196 : IProblem
    {
        public bool Test()
        {
            var descriptions = new[] {new[] {20, 15, 1}, new[]{20, 17, 0}, new[] {50, 20, 1}, new[] {50, 80, 0}, new[] {80, 19, 1}};

            var expected = new[] { 15, 20, 17, 50, 19, 80 };

            var result = new List<int>();
            CreateBinaryTree(descriptions).InOrder(result);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;

            public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
            {
                this.val = val;
                this.left = left;
                this.right = right;
            }

            public void InOrder(List<int> inorder)
            {
                left?.InOrder(inorder);
                inorder.Add(val);
                right?.InOrder(inorder);
            }
        }

        public TreeNode CreateBinaryTree(int[][] descriptions)
        {
            var nodes = new Dictionary<int, TreeNode>();
            var parents = new HashSet<int>();
            foreach (var d in descriptions)
            {
                if (!nodes.ContainsKey(d[0]))
                {
                    var parent = new TreeNode(d[0]);
                    nodes[d[0]] = parent;
                }
                if (!nodes.ContainsKey(d[1]))
                {
                    var child = new TreeNode(d[1]);
                    nodes[d[1]] = child;
                }
                parents.Add(d[0]);
                if (d[2] == 1)
                    nodes[d[0]].left = nodes[d[1]];
                else
                    nodes[d[0]].right = nodes[d[1]];
            }
            foreach (var d in descriptions)
                parents.Remove(d[1]);

            return nodes[parents.First()];
        }
    }
}
