using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2147 : IProblem
    {
        public bool Test()
        {
            var corridor = "SSPPSPS";

            var expected = 3;

            var result = NumberOfWays(corridor);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumberOfWays(string corridor)
        {
            var n = corridor.Length;
            long result = 1;
            var chairs = 0;
            var mod = 1000000007;
            for (int i = 0; i < n; i++)
            {
                if (corridor[i] == 'S')
                    chairs++;
                if (chairs == 2)
                {
                    var next = i + 1;
                    while (next < n && corridor[next] != 'S')
                        next++;
                    if (next < n)
                    {
                        result = result * (next - i) % mod;
                        i = next;
                        chairs = 1;
                    }
                }
            }

            if (chairs != 2)
                return 0;

            return (int)result;
        }
    }
}
