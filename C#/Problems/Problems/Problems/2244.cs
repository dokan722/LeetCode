using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    // SAME AS 2870
    public class _2244 : IProblem
    {
        public bool Test()
        {
            var tasks = new[] { 2, 2, 3, 3, 2, 4, 4, 4, 4, 4 };

            var expected = 4;

            var result = MinimumRounds(tasks);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumRounds(int[] tasks)
        {
            var counts = new Dictionary<int, int>();
            foreach (var task in tasks)
            {
                if (counts.ContainsKey(task))
                    counts[task]++;
                else
                    counts[task] = 1;
            }

            var result = 0;
            foreach (var count in counts)
            {
                if (count.Value == 1)
                    return -1;
                var mod = count.Value % 3;
                if (mod == 0)
                    result += count.Value / 3;
                else
                    result += count.Value / 3 + 1;
            }

            return result;
        }
    }
}
