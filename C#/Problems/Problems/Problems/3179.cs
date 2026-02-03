using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3179 : IProblem
    {
        public bool Test()
        {
            var n = 4;
            var k = 5;

            var expected = 56;

            var result = ValueAfterKSeconds(n, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int ValueAfterKSeconds(int n, int k)
        {
            var arr = new int[n];
            var mod = 1000000007;
            Array.Fill(arr, 1);
            for (int i = 0; i < k; ++i)
            for (int j = 1; j < n; ++j)
                arr[j] = (arr[j - 1] + arr[j]) % mod;
            return arr[n - 1];
        }
    }
}
