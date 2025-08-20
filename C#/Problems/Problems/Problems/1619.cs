using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1619 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 1, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 3 };

            var expected = 2.0;

            var result = TrimMean(arr);

            Console.WriteLine(result);

            return result == expected;
        }

        public double TrimMean(int[] arr)
        {
            Array.Sort(arr);
            var n = arr.Length;
            var outliners = n / 20;

            var sum = 0;
            for (var i = outliners; i < n - outliners; i++)
            {
                sum += arr[i];
            }

            return (double)sum / (n - 2 * outliners);
        }
    }
}
