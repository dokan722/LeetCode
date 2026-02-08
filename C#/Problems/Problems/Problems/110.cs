using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Problems.Problems._637;

namespace Problems.Problems
{
    public class _110 : IProblem
    {
        public bool Test()
        {
            var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));

            var expected = true;

            var result = IsBalanced(root);

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
    }
}