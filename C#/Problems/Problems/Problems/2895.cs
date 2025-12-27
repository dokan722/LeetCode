using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2895 : IProblem
    {
        public bool Test()
        {
            var processorTime = new List<int> { 10, 20 };
            var tasks = new List<int> { 2, 3, 1, 2, 5, 8, 4, 3 };

            var expected = 23;

            var result = MinProcessingTime(processorTime, tasks);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinProcessingTime(IList<int> processorTime, IList<int> tasks)
        {
            var n = processorTime.Count;
            var sortedTasks = tasks.OrderBy(x => x).ToArray();
            var sortedProcessors = processorTime.OrderBy(x => x).ToArray();
            var result = 0;
            for (int i = 0; i < n; ++i)
            {
                result = Math.Max(result, sortedProcessors[i] + sortedTasks[4 * (n - i) - 1]);
            }

            return result;
        }
    }
}
