using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _795 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 9, 2, 5, 6 };
            var left = 2;
            var right = 8;

            var expected = 7;

            var result = NumSubarrayBoundedMax(nums, left, right);

            Console.WriteLine(result);

            return expected == result;
        }

        public int NumSubarrayBoundedMax(int[] nums, int left, int right)
        {
            var n = nums.Length;
            var count = 0;
            var properElements = new List<int>();
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                if (nums[i] <= right)
                {
                    if (nums[i] >= left)
                        properElements.Add(i);
                    count++;
                }
                else
                {
                    if (properElements.Any() && count > 0)
                        result += GetProperSubarrays(i, count, properElements);
                    count = 0;
                    properElements.Clear();
                }
            }
            if (properElements.Any() && count > 0)
                result += GetProperSubarrays(n, count, properElements);


            return result;
        }

        private int GetProperSubarrays(int index, int count, List<int> properElements)
        {
            var start = index - count;
            var result = 0;
            foreach (var properElement in properElements)
            {
                result += (properElement - start + 1) * (index - properElement);
                start = properElement + 1;
            }

            return result;
        }
    }
}
