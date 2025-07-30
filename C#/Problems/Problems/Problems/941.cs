using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _941 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 0, 3, 2, 1 };

            var expected = true;

            var result = ValidMountainArray(arr);

            return expected == result;
        }

        public bool ValidMountainArray(int[] arr)
        {
            if (arr.Length < 3 || arr[0] >= arr[1])
                return false;
            var climbing = true;
            for (int i = 1; i < arr.Length; i++)
            {
                if (climbing && arr[i] > arr[i - 1])
                    continue;
                climbing = false;
                if (!climbing && arr[i] < arr[i - 1])
                    continue;
                return false;
            }

            return !climbing;
        }
    }
}
