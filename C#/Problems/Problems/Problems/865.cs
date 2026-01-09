using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _865 : IProblem
    {
        protected class TreeNode
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
        public bool Test()
        {
            var expected = new TreeNode(2, new TreeNode(7), new TreeNode(4));
            var root = new TreeNode(3, new TreeNode(5, new TreeNode(6), expected), new TreeNode(1, new TreeNode(0), new TreeNode(8)));

            var result = SubtreeWithAllDeepest(root);

            return result == expected;
        }

        private int _maxDepth = 0;
        private TreeNode _deepest = null;

        protected TreeNode SubtreeWithAllDeepest(TreeNode root)
        {
            DfsDepth(root, 0);
            return _deepest;
        }

        private int DfsDepth(TreeNode root, int parentDepth)
        {
            if (root == null)
                return parentDepth;
            var left = DfsDepth(root.left, parentDepth + 1);
            var right = DfsDepth(root.right, parentDepth + 1);
            if (left == right && right >= _maxDepth)
            {
                _deepest = root;
                _maxDepth = right;
            }

            return Math.Max(left, right);
        }
    }
}
