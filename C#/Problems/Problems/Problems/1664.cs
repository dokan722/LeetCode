using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1664 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 1, 6, 4 };

            var expected = 1;

            var result = WaysToMakeFair(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int WaysToMakeFair(int[] nums)
        {
            var n = nums.Length;
            var evenSum = 0;
            var oddSum = 0;
            for (int i = 0; i < n; ++i)
            {
                if (i % 2 == 0)
                    evenSum += nums[i];
                else
                    oddSum += nums[i];
            }

            var currEven = 0;
            var currOdd = 0;
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (i % 2 == 0)
                {

                    if (currEven + (oddSum - currOdd) == currOdd + (evenSum - currEven - nums[i]))
                        result++;
                    currEven += nums[i];
                }
                else
                {
                    if (currEven + (oddSum - currOdd - nums[i]) == currOdd + (evenSum - currEven))
                        result++;
                    currOdd += nums[i];
                }
            }

            return result;
        }
    }
}
