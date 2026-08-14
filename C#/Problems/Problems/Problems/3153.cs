using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3153 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 13, 23, 12 };

            var expected = 4;

            var result = SumDigitDifferences(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public long SumDigitDifferences(int[] nums)
        {
            var n = nums.Length;
            var l = nums[0].ToString().Length;
            var digs = new int[l][];
            for (int i = 0; i < l; ++i)
                digs[i] = new int[10];
            long result = 0;
            for (int i = 0; i < n; ++i)
            {
                var num = nums[i];
                for (int j = 0; j < l; ++j)
                {
                    var c = num % 10;
                    var diff = 0;
                    for (int k = 0; k < 10; ++k)
                    {
                        if (k != c)
                            diff += digs[j][k];
                    }
                    result += diff;
                    digs[j][c]++;
                    num /= 10;
                }
            }

            return result;
        }
    }
}
