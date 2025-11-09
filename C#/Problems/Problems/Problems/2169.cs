using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2169 : IProblem
    {
        public bool Test()
        {
            var num1 = 2;
            var num2 = 3;

            var expected = 3;

            var result = CountOperations(num1, num2);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountOperations(int num1, int num2)
        {
            if (num1 < num2)
                return CountOperations(num2, num1);
            if (num2 == 0)
                return 0;
            var ops = num1 / num2;
            var next = num1 % num2;
            return ops + CountOperations(num2, next);
        }
    }
}
