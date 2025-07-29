using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2411 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 0, 2, 1, 3 };

            var expected = new[] { 3, 3, 2, 2, 1 };

            var result = SmallestSubarrays(nums);

            return result.SequenceEqual(expected);
        }

        public int[] SmallestSubarrays(int[] nums)
        {
            int n = nums.Length;
            int[] lastChange = new int[32];
            Array.Fill(lastChange, -1);
            int[] result = new int[n];
            for (int i = n - 1; i >= 0; --i)
            {
                int last = i;
                var bits = IntToBit(nums[i]);
                for (int j = 0; j < 32; ++j)
                {
                    if (bits[j] == 0)
                    {
                        if (lastChange[j] != -1)
                        {
                            last = Math.Max(last, lastChange[j]);
                        }
                    }
                    else
                    {
                        lastChange[j] = i;
                    }
                }
                result[i] = last - i + 1;
            }
            return result;
        }

        private int[] IntToBit(int value)
        {
            int[] bits = new int[32];

            for (int i = 0; i < 32; i++)
            {
                bits[31 - i] = (value >> i) & 1;
            }

            return bits;
        }
    }
}
