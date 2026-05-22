using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1953 : IProblem
    {
        public bool Test()
        {
            var milestones = new[] { 1, 2, 3 };

            var expected = 6;

            var result = NumberOfWeeks(milestones);

            Console.WriteLine(result);

            return expected == result;
        }

        public long NumberOfWeeks(int[] milestones)
        {
            long sum = 0;
            int mx = 0;
            foreach (var m in milestones)
            {
                sum += m;
                mx = Math.Max(mx, m);
            }

            return 2 * mx > sum ? 2 * (sum - mx) + 1 : sum;
        }
    }
}
