using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2996 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 3, 2, 5 };

            var expected = 6;

            var result = MissingInteger(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MissingInteger(int[] nums)
        {
            var n = nums.Length;
            var s = nums[0];
            for (int i = 1; i < n; ++i)
            {
                if (nums[i] != nums[i - 1] + 1)
                    break;
                s += nums[i];
            }
            if (s > 50)
                return s;
            var present = new bool[51];
            foreach (var num in nums)
                present[num] = true;
            for (int i = s; i <= 50; ++i)
                if (!present[i])
                    return i;
            return 51;
        }
    }
}
