using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3011 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 3, 16, 8, 4, 2 };

            var expected = false;

            var result = CanSortArray(nums);

            return expected == result;
        }

        public bool CanSortArray(int[] nums)
        {
            var n = nums.Length;
            var bits = new int[n];
            for (int i = 0; i < n; ++i)
                bits[i] = CountBits(nums[i]);
            for (int i = 0; i < n - 1; ++i)
            {
                for (int j = i + 1; j < n; ++j)
                {
                    if (nums[j] < nums[i] && bits[i] != bits[j])
                        return false;
                }
            }

            return true;
        }


        private int CountBits(int num)
        {
            int bits = 0;

            for (int i = 0; i <= 9; ++i)
            {
                bits += num & 1;
                num = (num >> 1);
            }

            return bits;
        }
    }
}
