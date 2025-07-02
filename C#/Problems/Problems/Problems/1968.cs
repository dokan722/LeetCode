using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1968 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 1, 2, 3, 4, 5 };

            var expected = new int[] { 1, 3, 2, 5, 4 };

            var result = RearrangeArray(nums);

            return expected.SequenceEqual(result);
        }

        public int[] RearrangeArray(int[] nums)
        {
            for (int i = 1; i < nums.Length - 1; i++)
            {
                if ((nums[i - 1] < nums[i] && nums[i] < nums[i + 1])
                    || (nums[i - 1] > nums[i] && nums[i] > nums[i + 1]))
                    (nums[i], nums[i + 1]) = (nums[i + 1], nums[i]);
            }

            return nums;
        }
    }
}
