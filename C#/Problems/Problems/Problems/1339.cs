using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Problems.Problems
{
    public class _1339 : IProblem
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
            var root = new TreeNode(1, new TreeNode(2, new TreeNode(4), new TreeNode(5)), new TreeNode(3, new TreeNode(6)));

            var expected = 110;

            var result = MaxProduct(root);

            Console.WriteLine(result);

            return result == expected;
        }

        protected int MaxProduct(TreeNode root)
        {
            SumRoots(root);

            var total = root.val;
            var stack = new Stack<TreeNode>();
            if (root.left != null)
                stack.Push(root.left);
            if (root.right != null)
                stack.Push(root.right);

            long result = 0;
            var mod = 1000000007;
            while (stack.Any())
            {
                var next = stack.Pop();
                if (next.left != null)
                    stack.Push(next.left);
                if (next.right != null)
                    stack.Push(next.right);
                result = Math.Max(result, (long)next.val * (total - next.val));
            }

            return (int)(result % mod);
        }

        private void SumRoots(TreeNode root)
        {
            if (root.left != null)
                SumRoots(root.left);
            if (root.right != null)
                SumRoots(root.right);
            root.val += (root.left?.val ?? 0) + (root.right?.val ?? 0);
        }
    }
}
