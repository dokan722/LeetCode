using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1509 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 5, 3, 2, 4 };

            var expected = 0;

            var result = MinDifference(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinDifference(int[] nums)
        {
            if (nums.Length < 4)
                return 0;

            var max1 = int.MinValue;
            var max2 = int.MinValue;
            var max3 = int.MinValue;
            var max4 = int.MinValue;
            var min1 = int.MaxValue;
            var min2 = int.MaxValue;
            var min3 = int.MaxValue;
            var min4 = int.MaxValue;
            foreach (var n in nums)
            {
                if (n >= max1)
                {
                    max4 = max3;
                    max3 = max2;
                    max2 = max1;
                    max1 = n;
                }
                else if (n >= max2)
                {
                    max4 = max3;
                    max3 = max2;
                    max2 = n;
                }
                else if (n >= max3)
                {
                    max4 = max3;
                    max3 = n;
                }
                else if (n > max4)
                    max4 = n;

                if (n <= min1)
                {
                    min4 = min3;
                    min3 = min2;
                    min2 = min1;
                    min1 = n;
                }
                else if (n <= min2)
                {
                    min4 = min3;
                    min3 = min2;
                    min2 = n;
                }
                else if (n <= min3)
                {
                    min4 = min3;
                    min3 = n;
                }
                else if (n < min4)
                    min4 = n;
            }

            return Math.Min(Math.Min(max1 - min4, max4 - min1), Math.Min(max2 - min3, max3 - min2));
        }
    }
}
