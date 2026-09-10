using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2265 : IProblem
    {
        public bool Test()
        {
            var root = new TreeNode(1);

            var expected = 1;

            var result = AverageOfSubtree(root);

            Console.WriteLine(result);

            return result == expected;
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
        }

        private int AverageOfSubtree(TreeNode root)
        {
            return GetRec(root).R;
        }

        private (int S, int C, int R) GetRec(TreeNode node)
        {
            (int S, int C, int R) left = node.left == null ? (0, 0, 0) : GetRec(node.left);
            (int S, int C, int R) right = node.right == null ? (0, 0, 0) : GetRec(node.right);
            var s = left.S + right.S + node.val;
            var c = left.C + right.C + 1;
            var r = left.R + right.R + ((s / c) == node.val ? 1 : 0);
            return (s, c, r);
        }
    }
}
