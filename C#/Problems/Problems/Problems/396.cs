using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _396 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 4, 3, 2, 6 };

            var expected = 26;

            var result = MaxRotateFunction(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaxRotateFunction(int[] nums)
        {
            var n = nums.Length;
            var sum = 0;
            var fvalue = 0;
            for (int i = 0; i < n; ++i)
            {
                sum += nums[i];
                fvalue += nums[i] * i;
            }

            var result = fvalue;

            for (int i = 1; i < n; ++i)
            {
                fvalue += sum;
                fvalue -= nums[n - i] * n;
                result = Math.Max(result, fvalue);
            }

            return result;
        }
    }
}
