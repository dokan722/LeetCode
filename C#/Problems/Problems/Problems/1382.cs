using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1382 : IProblem
    {
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
        public bool Test()
        {
            var root = new TreeNode(2, new TreeNode(1), new TreeNode(3, null, new TreeNode(7)));
            var result = BalanceBST(root);

            return IsBalanced(result);
        }

        public bool IsBalanced(TreeNode root)
        {
            return IsBalancedRec(root) != -1;
        }

        public int IsBalancedRec(TreeNode root)
        {
            if (root == null)
                return 0;
            var left = IsBalancedRec(root.left);
            if (left == -1)
                return -1;
            var right = IsBalancedRec(root.right);
            if (right == -1)
                return -1;
            if (Math.Abs(left - right) > 1)
                return -1;
            return Math.Max(left, right) + 1;
        }

        public TreeNode BalanceBST(TreeNode root)
        {
            var inorder = new List<int>();
            InOrder(root, inorder);
            return Build(inorder, 0, inorder.Count - 1);
        }

        private void InOrder(TreeNode root, List<int> nodes)
        {
            if (root == null)
                return;
            InOrder(root.left, nodes);
            nodes.Add(root.val);
            InOrder(root.right, nodes);
        }

        private TreeNode Build(List<int> nodes, int l, int r)
        {
            if (l > r)
                return null;
            var mid = (l + r) / 2;
            var left = Build(nodes, l, mid - 1);
            var right = Build(nodes, mid + 1, r);

            return new TreeNode(nodes[mid], left, right);
        }
    }
}
