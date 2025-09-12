using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3115 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 4, 2, 9, 5, 3 };

            var expected = 3;

            var result = MaximumPrimeDifference(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MaximumPrimeDifference(int[] nums)
        {
            var n = nums.Length;
            var possiblePrimeDivisors = new[] { 2, 3, 5, 7 };
            var first = -1;
            var last = 0;
            for (int i = 0; i < n; ++i)
            {
                var isPrime = true;
                foreach (var prime in possiblePrimeDivisors)
                {
                    if (nums[i] == 1 || (nums[i] % prime == 0 && nums[i] / prime != 1))
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    if (first == -1)
                        first = i;
                    last = i;
                }
            }

            return last - first;
        }
    }
}
