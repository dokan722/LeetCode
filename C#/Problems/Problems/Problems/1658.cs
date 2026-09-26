using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1658 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 1, 4, 2, 3 };
            var x = 5;

            var expceted = 2;

            var result = MinOperations(nums, x);

            Console.WriteLine(result);

            return result == expceted;
        }

        public int MinOperations(int[] nums, int x)
        {
            var n = nums.Length;
            var total = 0;
            foreach (var num in nums)
                total += num;
            if (total < x)
                return -1;
            if (total == x)
                return n;
            var result = int.MaxValue;
            var r = 0;
            var cur = 0;
            var req = total - x;
            for (int i = 0; i < n; ++i)
            {
                while (r < n && cur < req)
                    cur += nums[r++];
                if (cur == req)
                    result = Math.Min(result, n - (r - i));
                if (cur < req)
                    break;
                cur -= nums[i];
            }

            return result == int.MaxValue ? -1 : result;
        }
    }
}
