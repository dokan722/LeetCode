using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _611 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 4, 2, 3, 4 };

            var expected = 4;

            var result = TriangleNumber(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int TriangleNumber(int[] nums)
        {
            var n = nums.Length;
            if (n < 3)
                return 0;
            var counts = new int[1001];
            var presentNums = new HashSet<int>();
            foreach (var num in nums)
            {
                counts[num]++;
                presentNums.Add(num);
            }
            presentNums.Remove(0);

            var smallerOrEqual = new int[1001];
            smallerOrEqual[1] = counts[1];
            for (int i = 2; i <= 1000; ++i)
            {
                smallerOrEqual[i] = smallerOrEqual[i - 1] + counts[i];
            }

            long result = 0;
            foreach (var num1 in presentNums)
            {
                foreach (var num2 in presentNums)
                {
                    var tooSmall = Math.Max(num1, num2) - Math.Min(num1, num2);
                    var num3Poss = num1 + num2 > 1000 ? n - 2 : smallerOrEqual[num1 + num2 - 1] - 2;
                    num3Poss -= smallerOrEqual[tooSmall] - (tooSmall >= Math.Min(num1, num2) ? 1 : 0);
                    if (num1 != num2) 
                        result += counts[num1] * counts[num2] * num3Poss;
                    else
                        result += (counts[num1] - 1) * counts[num2] * num3Poss;

                }
            }

            return (int)(result / 6);
        }
    }
}
