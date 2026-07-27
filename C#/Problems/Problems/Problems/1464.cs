using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1464 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 4, 5, 2 };

            var expected = 12;

            var result = MaxProduct(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxProduct(int[] nums)
        {
            var max1 = int.MinValue;
            var max2 = int.MinValue;
            foreach (var num in nums)
            {
                if (max1 <= num)
                {
                    max2 = max1;
                    max1 = num;
                }
                else if (max2 <= num)
                    max2 = num;
            }

            return (max1 - 1) * (max2 - 1);
        }
    }
}
