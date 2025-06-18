using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _637 : IProblem
    {
        public bool Test()
        {
            var tree = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));

            var expected = new List<double> {3.0, 14.5, 11.0};

            var result = AverageOfLevels(tree);

            return expected.SequenceEqual(result);
        }

        public IList<double> AverageOfLevels(TreeNode root)
        {
            var depthDict = new Dictionary<int, DepthData>();

            TravelTree(root, 0, depthDict);

            var result = new List<double>();

            foreach (var i in depthDict.Values)
                result.Add(i.Sum / i.Count);

            return result;
        }

        private void TravelTree(TreeNode root, int depth, Dictionary<int, DepthData> depthDic)
        {
            if (depthDic.ContainsKey(depth))
            {
                depthDic[depth].Count += 1;
                depthDic[depth].Sum += root.val;
            }
            else
            {
                depthDic[depth] = new DepthData {Count = 1, Sum = root.val};
            }

            if (root.left != null)
                TravelTree(root.left, depth + 1, depthDic);
            if (root.right != null)
                TravelTree(root.right, depth +1, depthDic);
        }

        private class DepthData
        {
            public double Count;
            public double Sum;
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

    }


}
