using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _154 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 5 };

            var expected = 1;

            var result = FindMin(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FindMin(int[] nums)
        {
            var n = nums.Length;
            if (n == 1)
                return nums[0];
            if (nums[0] < nums[n - 1])
                return nums[0];
            var l = 1;
            var r = n - 1;
            while (l < r && nums[l] == nums[r])
                l++;
            while (l < r)
            {
                var mid = (l + r) / 2;
                if (nums[mid - 1] > nums[mid])
                    return nums[mid];
                if (nums[mid] <= nums[r])
                    r = mid;
                else
                    l = mid + 1;
            }

            return nums[l];
        }
    }
}
