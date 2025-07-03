using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2856 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 1, 2, 3, 4 };

            var expected = 0;

            var result = MinLengthAfterRemovals(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinLengthAfterRemovals(IList<int> nums)
        {
            var n = nums.Count;
            if (n < 2)
                return n;
            var left = 0;
            var right = n - 1;
            var med = nums[n / 2];
            while (nums[left] < med)
                left++;
            while (nums[right] > med)
                right--;
            var lesser = left;
            var bigger = n - 1 - right;
            var equal = n - lesser - bigger;
            if (lesser + bigger > equal)
                return n % 2;


            return equal - lesser - bigger;
        }
    }
}
