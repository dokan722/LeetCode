using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3074 : IProblem
    {
        public bool Test()
        {
            var apple = new[] { 1, 3, 2 };
            var capacity = new[] { 4, 3, 1, 5, 2 };

            var expected = 2;

            var result = MinimumBoxes(apple, capacity);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumBoxes(int[] apple, int[] capacity)
        {
            var m = capacity.Length;
            var appleSum = 0;
            foreach (var a in apple)
                appleSum += a;
            Array.Sort(capacity);
            var i = m - 1;
            while (appleSum > 0)
            {
                appleSum -= capacity[i];
                i--;
            }

            return m - i - 1;
        }
    }
}
