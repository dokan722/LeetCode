using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Problems.Problems._637;

namespace Problems.Problems
{
    public class _1161 : IProblem
    {
        public bool Test()
        {
            var root = new TreeNode(1, new TreeNode(7, new TreeNode(7), new TreeNode(-8)), new TreeNode(0));

            var expected = 2;

            var result = MaxLevelSum(root);

            Console.WriteLine(result);

            return result == expected;
        }

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


        protected int MaxLevelSum(TreeNode root)
        {
            var result = 1;
            var maxSum = root.val;
            var level = 0;
            var nodes = new Queue<TreeNode>();
            nodes.Enqueue(root);
            while (nodes.Any())
            {
                var currSum = 0;
                level++;
                var curr = nodes.Count;
                for (int i = 0; i < curr; ++i)
                {
                    var next = nodes.Dequeue();
                    currSum += next.val;
                    if (next.left != null)
                        nodes.Enqueue(next.left);
                    if (next.right != null)
                        nodes.Enqueue(next.right);
                }

                if (currSum > maxSum)
                {
                    result = level;
                    maxSum = currSum;
                }
            }
            return result;
        }

    }
}
