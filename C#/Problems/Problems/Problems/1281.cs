using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1281 : IProblem
    {
        public bool Test()
        {
            var n = 234;

            var expected = 15;

            var result = SubtractProductAndSum(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SubtractProductAndSum(int n)
        {
            var mul = 1;
            var sum = 0;
            while (n > 0)
            {
                var d = n % 10;
                mul *= d;
                sum += d;
                n /= 10;
            }

            return mul - sum;
        }
    }
}
