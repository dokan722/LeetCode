using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3723 : IProblem
    {
        public bool Test()
        {
            var num = 2;
            var sum = 3;

            var expected = "30";

            var result = MaxSumOfSquares(num, sum);

            Console.WriteLine(result);

            return result == expected;
        }

        public string MaxSumOfSquares(int num, int sum)
        {
            if (9 * num < sum)
                return string.Empty;
            var nines = sum / 9;
            var rest = sum % 9;
            var zeros = num - nines - (rest == 0 ? 0 : 1);
            return new string('9', nines) + (rest == 0 ? "" : rest.ToString()) + new string('0', zeros);
        }
    }
}
