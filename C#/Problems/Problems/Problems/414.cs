using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _414 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 2, 1 };

            var expected = 1;

            var result = ThirdMax(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int ThirdMax(int[] nums)
        {
            var mxs = new long[] { long.MinValue, long.MinValue, long.MinValue };
            foreach (var num in nums)
            {
                if (num >= mxs[0])
                {
                    if (num != mxs[0])
                    {
                        mxs[2] = mxs[1];
                        mxs[1] = mxs[0];
                    }
                    mxs[0] = num;
                }
                else if (num >= mxs[1])
                {
                    if (num != mxs[1])
                        mxs[2] = mxs[1];
                    mxs[1] = num;
                }
                else if (num >= mxs[2])
                {
                    mxs[2] = num;
                }
            }

            return (int)(mxs[2] != long.MinValue ? mxs[2] : mxs[0]);
        }
    }
}
