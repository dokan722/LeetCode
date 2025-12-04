using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1913 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 4, 2, 5, 9, 7, 4, 8 };

            var expected = 64;

            var result = MaxProductDifference(nums);
            
            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxProductDifference(int[] nums)
        {
            var n = nums.Length;
            var max1 = nums[0];
            var max2 = int.MinValue;
            var min1 = nums[0];
            var min2 = int.MaxValue;
            for (int i = 1; i < n; ++i)
            {
                if (nums[i] >= max2)
                {
                    if (nums[i] >= max1)
                    {
                        max2 = max1;
                        max1 = nums[i];
                    }
                    else
                        max2 = nums[i];
                }

                if (nums[i] <= min2)
                {
                    if (nums[i] <= min1)
                    {
                        min2 = min1;
                        min1 = nums[i];
                    }
                    else
                        min2 = nums[i];
                }
            }

            return (max1 * max2) - (min1 * min2);
        }
    }
}
