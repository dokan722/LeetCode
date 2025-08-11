using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2438 : IProblem
    {
        public bool Test()
        {
            var n = 15;
            var queries = new[] { new[] { 0, 1 }, new[] { 2, 2 }, new[] { 0, 3 } };

            var expected = new[] { 2, 4, 64 };

            var result = ProductQueries(n, queries);

            return result.SequenceEqual(expected);
        }

        private int[] _powersOfTwo = new[]
        {
            1,
            2,
            4,
            8,
            16,
            32,
            64,
            128,
            256,
            512,
            1024,
            2048,
            4096,
            8192,
            16384,
            32768,
            65536,
            131072,
            262144,
            524288,
            1048576,
            2097152,
            4194304,
            8388608,
            16777216,
            33554432,
            67108864,
            134217728,
            268435456,
            536870912,
            1073741824
        };

        public int[] ProductQueries(int n, int[][] queries)
        {
            var l = queries.Length;
            var result = new int[l];
            var arr = GetProblemArray(n);
            var k = arr.Length;
            var mod = 1000000007;
            var proc = new int[k][];
            for (int i = 0; i < k; ++i)
                proc[i] = new int[k];
            for (int i = 0; i < k; ++i)
            {
                proc[i][i] = arr[i];
                for (int j = i + 1; j < k; ++j)
                    proc[i][j] = (int)((long)proc[i][j - 1] * arr[j] % mod);
            }
            for (int i = 0; i < l; ++i)
                result[i] = proc[queries[i][0]][queries[i][1]];

            return result;
        }

        private int[] GetProblemArray(int n)
        {
            var result = new List<int>();
            var bits = TransformToBitArray(n);
            for (int i = 0; i < bits.Length; i++)
            {
                if (bits[30 - i] == 1)
                    result.Add(_powersOfTwo[i]);
            }

            return result.ToArray();
        }

        private int[] TransformToBitArray(int num)
        {
            int[] bits = new int[31];

            for (int i = 30; i >= 0; i--)
            {
                bits[30 - i] = (num >> i) & 1;
            }

            return bits;
        }
    }
}
