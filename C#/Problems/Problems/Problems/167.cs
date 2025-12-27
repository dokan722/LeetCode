using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _167 : IProblem
    {
        public bool Test()
        {
            var numbers = new[] { 2, 7, 11, 15 };
            var target = 9;

            var expected = new[] { 1, 2 };

            var result = TwoSum(numbers, target);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] TwoSum(int[] numbers, int target)
        {
            var left = 0;
            var right = numbers.Length - 1;
            while (left < right)
            {
                if (target < numbers[left] + numbers[right])
                    right--;
                else if (target > numbers[left] + numbers[right])
                    left++;
                else
                    return new[] { left + 1, right + 1 };
            }

            return null;
        }
    }
}
