using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _852 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 0, 10, 5, 2 };

            var expected = 1;

            var result = PeakIndexInMountainArray(arr);

            Console.WriteLine(result);

            return expected == result;
        }

        public int PeakIndexInMountainArray(int[] arr)
        {
            var left = 0;
            var right = arr.Length - 1;
            while (left < right)
            {
                var mid = (left + right) / 2;
                if (arr[mid] < arr[mid + 1])
                    left = mid + 1;
                else
                    right = mid;
            }

            return left;
        }
    }
}
