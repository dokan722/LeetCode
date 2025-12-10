using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3577 : IProblem
    {
        public bool Test()
        {
            var complexity = new[] { 1, 2, 3 };

            var expected = 2;

            var result = CountPermutations(complexity);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountPermutations(int[] complexity)
        {
            var n = complexity.Length;
            var mod = 1000000007;
            for (int i = 1; i < n; ++i)
            {
                if (complexity[i] <= complexity[0])
                    return 0;
            }

            long result = 1;
            for (int i = 1; i < n; ++i)
                result = (result * i) % mod;

            return (int)result;
        }
    }
}
