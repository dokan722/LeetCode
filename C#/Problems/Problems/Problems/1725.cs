using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1725 : IProblem
    {
        public bool Test()
        {
            var rectangles = new int[][] {new int[] {5, 8}, new int[] {3, 9}, new int[] {5, 12}, new int[] {16, 5}};

            var expected = 3;

            var result = CountGoodRectangles(rectangles);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountGoodRectangles(int[][] rectangles)
        {
            var max = 0;
            var count = 0;
            foreach (var r in rectangles)
            {
                var side = Math.Min(r[0], r[1]);
                if (side == max)
                    count++;
                else if (side > max)
                {
                    max = side;
                    count = 1;
                }
            }

            return count;
        }
    }
}
