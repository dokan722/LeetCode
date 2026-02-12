using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2001 : IProblem
    {
        public bool Test()
        {
            var rectangles = new[] { new[] { 4, 8 }, new[] { 3, 6 }, new[] { 10, 20 }, new[] { 15, 30 } };

            var expected = 6;

            var result = InterchangeableRectangles(rectangles);

            Console.WriteLine(result);

            return result == expected;
        }

        public long InterchangeableRectangles(int[][] rectangles)
        {
            var counts = new Dictionary<double, int>();
            long result = 0;
            foreach (var r in rectangles)
            {
                var val = (double)r[0] / r[1];
                if (counts.ContainsKey(val))
                {
                    result += counts[val];
                    counts[val]++;
                }
                else
                    counts[val] = 1;
            }

            return result;
        }
    }
}
