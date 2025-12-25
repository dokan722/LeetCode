using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3075 : IProblem
    {
        public bool Test()
        {
            var happiness = new[] { 1, 2, 3 };
            var k = 2;

            var expected = 4;

            var result = MaximumHappinessSum(happiness, k);

            Console.WriteLine(result);

            return result == expected;

        }

        public long MaximumHappinessSum(int[] happiness, int k)
        {
            var n = happiness.Length;
            Array.Sort(happiness);

            long result = 0;
            for (int i = 0; i < k; ++i)
            {
                result += Math.Max(0, happiness[n - i - 1] - i);
            }

            return result;
        }
    }
}
