using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3096 : IProblem
    {
        public bool Test()
        {
            var possible = new[] { 1, 0, 1, 0 };

            var expected = 1;

            var result = MinimumLevels(possible);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumLevels(int[] possible)
        {
            var n = possible.Length;
            var total = 0;
            foreach (var p in possible)
                total += p == 0 ? -1 : 1;

            var alice = 0;
            for (int i = 0; i < n - 1; ++i)
            {
                alice += possible[i] == 0 ? -1 : 1;
                var bob = total - alice;
                if (bob < alice)
                    return i + 1;
            }
            return -1;
        }
    }
}
