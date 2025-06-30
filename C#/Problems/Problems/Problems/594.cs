using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _594 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 1, 3, 2, 2, 5, 2, 3, 7 };

            var expected = 5;

            var result = FindLHS(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FindLHS(int[] nums)
        {
            Array.Sort(nums);
            var result = 0;
            var count = 1;
            var prevCount = 0;
            var prev = nums[0];
            for (int i = 1; i < nums.Length; ++i)
            {
                if (nums[i] == prev)
                    count++;
                else
                {
                    if (prevCount != 0 && count + prevCount > result)
                        result = count + prevCount;
                    if (nums[i] - 1 != prev)
                    {
                        prevCount = 0;
                    }
                    else
                    {
                        prevCount = count;
                    }
                    count = 1;
                    prev = nums[i];
                }
            }

            if (prevCount != 0 && count + prevCount > result)
                result = count + prevCount;

            return result;
        }
    }
}
