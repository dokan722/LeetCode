using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3301 : IProblem
    {
        public bool Test()
        {
            var maximumHeight = new[] { 2, 3, 4, 3 };

            var expected = 10;

            var result = MaximumTotalSum(maximumHeight);

            Console.WriteLine(result);

            return result == expected;
        }

        public long MaximumTotalSum(int[] maximumHeight)
        {
            var n = maximumHeight.Length;
            Array.Sort(maximumHeight);
            var threshold = int.MaxValue;
            long result = 0;
            for (int i = n - 1; i >= 0; --i)
            {
                if (threshold < 1)
                    return -1;
                var curr = Math.Min(maximumHeight[i], threshold);
                result += curr;
                threshold = curr - 1;
            }

            return result;
        }
    }
}
