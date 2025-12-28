using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _75 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 0, 2, 1, 1, 0 };

            var expected = new[] { 0, 0, 1, 1, 2, 2 };

            SortColors(nums);

            Utils.Print1DArray(nums);

            return Utils.Compare1DArrays(nums, expected);
        }

        public void SortColors(int[] nums)
        {
            var left = 0;
            var mid = 0;
            var right = nums.Length - 1;
            while (mid <= right)
            {
                if (nums[mid] == 0)
                {
                    (nums[left], nums[mid]) = (nums[mid], nums[left]);
                    left++;
                    mid++;
                }
                else if (nums[mid] == 1)
                    mid++;
                else
                {
                    (nums[mid], nums[right]) = (nums[right], nums[mid]);
                    right--;
                }
            }
        }
    }
}
