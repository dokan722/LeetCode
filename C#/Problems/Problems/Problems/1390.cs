using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1390 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 21, 4, 7 };

            var expected = 32;

            var result = SumFourDivisors(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int SumFourDivisors(int[] nums)
        {
            var result = 0;

            foreach (var num in nums)
            {
                var sq = Math.Sqrt(num);
                var divs = (int)sq * sq == num ? 1 : 0;
                var sum = (int)sq * divs;
                for (int i = 1; i < sq; ++i)
                {
                    if (num % i == 0)
                    {
                        sum += i + num / i;
                        divs += 2;
                    }
                }

                if (divs == 4)
                    result += sum;
            }

            return result;
        }
    }
}
