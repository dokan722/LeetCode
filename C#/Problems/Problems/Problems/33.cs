using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _33 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 4, 5, 6, 7, 0, 1, 2 };
            var target = 0;

            var expected = 4;

            var result = Search(nums, target);

            Console.WriteLine(result);

            return result == expected;
        }

        public int Search(int[] nums, int target)
        {
            var l = 0;
            var r = nums.Length - 1;
            while (l < r)
            {
                var mid = (l + r) / 2;
                if (nums[mid] == target)
                    return mid;

                if (nums[mid] >= nums[l])
                {
                    if (nums[mid] < target)
                        l = mid + 1;
                    else if (nums[l] <= target)
                        r = mid - 1;
                    else
                        l = mid + 1;
                }
                else
                {
                    if (target < nums[mid])
                        r = mid - 1;
                    else if (target <= nums[r])
                        l = mid + 1;
                    else
                        r = mid - 1;

                }
            }
            return nums[l] == target ? l : -1;
        }
    }
}
