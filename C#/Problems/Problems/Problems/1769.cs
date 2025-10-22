using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1769 : IProblem
    {
        public bool Test()
        {
            var boxes = "001011";

            var expected = new[] { 11, 8, 5, 4, 3, 4 };

            var result = MinOperations(boxes);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public int[] MinOperations(string boxes)
        {
            var n = boxes.Length;
            var result = new int[n];
            var curr = 0;
            var balls = 0;
            for (int i = 0; i < n; ++i)
            {
                curr += balls;
                result[i] += curr;
                if (boxes[i] == '1')
                    balls++;
            }

            curr = 0;
            balls = 0;
            for (int i = n - 1; i >= 0; --i)
            {
                curr += balls;
                result[i] += curr;
                if (boxes[i] == '1')
                    balls++;
            }

            return result;
        }
    }
}
