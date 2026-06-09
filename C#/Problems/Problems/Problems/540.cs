using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _540 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 1, 2, 3, 3, 4, 4, 8, 8 };

            var expected = 2;

            var result = SingleNonDuplicate(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SingleNonDuplicate(int[] nums)
        {
            var n = nums.Length;
            var l = 0;
            var r = n - 1;
            while (l < r)
            {
                var mid = (l + r) / 2;
                if (nums[mid] == nums[mid + 1])
                {
                    if (mid % 2 == 0)
                        l = mid + 2;
                    else
                        r = mid - 1;
                }
                else if (nums[mid] == nums[mid - 1])
                {
                    if (mid % 2 == 1)
                        l = mid + 1;
                    else
                        r = mid - 2;
                }
                else
                    return nums[mid];
            }
            return nums[l];
        }
    }
}
