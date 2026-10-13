using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2897 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 6, 5, 8 };
            var k = 2;

            var expected = 261;

            var result = MaxSum(nums, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxSum(IList<int> nums, int k)
        {
            var bits = new long[32];
            var mod = 1000000007;
            long result = 0;
            foreach (var num in nums)
            {
                var c = num;
                var i = 0;
                while (c > 0)
                {
                    bits[i] += c & 1;
                    i++;
                    c >>= 1;
                }
            }
            for (int i = 0; i < k; ++i)
            {
                long cur = 1;
                long num = 0;
                var added = false;
                for (int j = 0; j < 32; ++j)
                {
                    if (bits[j] > 0)
                    {
                        num += cur;
                        bits[j]--;
                        added = true;
                    }
                    cur <<= 1;
                }
                if (!added)
                    break;
                result = (result + num * num) % mod;
            }

            return (int)result;
        }
    }
}
