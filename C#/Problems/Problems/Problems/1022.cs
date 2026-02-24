using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1022 : IProblem
    {
        public bool Test()
        {
            var root = new TreeNode(1, new TreeNode(0, new TreeNode(0), new TreeNode(1)), new TreeNode(1, new TreeNode(0), new TreeNode(1)));

            var expected = 22;

            var result = SumRootToLeaf(root);

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

        public int SumRootToLeaf(TreeNode root)
        {
            SumRootToLeafRec(root, 0);
            return _sum;
        }

        private int _sum;
        private void SumRootToLeafRec(TreeNode root, int val)
        {
            if (root == null)
                return;
            val = (val << 1) + root.val;
            if (root.left == null && root.right == null)
            {
                _sum += val;
                return;
            }
            SumRootToLeafRec(root.left, val);
            SumRootToLeafRec(root.right, val);
        }
    }
}
