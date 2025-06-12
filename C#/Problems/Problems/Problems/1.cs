using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    internal class _1 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 2, 7, 11, 15 };

            var target = 9;

            var expected = new int[] { 0, 1 };

            var result = TwoSum(nums, target);

            return expected[0] == result[0] && expected[1] == result[1];
        }

        public int[] TwoSum(int[] nums, int target)
        {
            var sumDic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; ++i)
            {
                if (sumDic.TryGetValue(target - nums[i], out var index))
                {
                    return new int[] { index, i };
                }
                if (!sumDic.ContainsKey(nums[i]))
                {
                    sumDic.Add(nums[i], i);
                }
            }

            return new int[] { 0, 0 };
        }
    }
}
