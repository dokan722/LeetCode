using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1524 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 1, 2, 3, 4, 5, 6, 7 };

            var expected = 16;

            var result = NumOfSubarrays(arr);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumOfSubarrays(int[] arr)
        {
            var n = arr.Length;
            var mod = 1000000007;
            var even = arr[0] % 2 == 0 ? 1 : 0;
            var odd = arr[0] % 2 == 0 ? 0 : 1;
            var result = odd;

            for (int i = 1; i < n; ++i)
            {
                if (arr[i] % 2 == 0)
                {
                    even += 1;
                }
                else
                {
                    var tmp = odd;
                    odd = even + 1;
                    even = tmp;
                }
                result = (result + odd) % mod;
            }

            return result;
        }
    }
}
