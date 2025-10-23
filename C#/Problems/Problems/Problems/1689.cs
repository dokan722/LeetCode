using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1689 : IProblem
    {
        public bool Test()
        {
            var n = "27346209830709182346";

            var expected = 9;

            var result = MinPartitions(n);

            Console.WriteLine(result);

            return result == expected;
        }
        public int MinPartitions(string n)
        {
            var maxDigit = '1';
            foreach (var i in n)
            {
                if (i > maxDigit)
                {
                    if (i == '9')
                        return 9;
                    maxDigit = i;
                }
            }

            return maxDigit - '0';
        }
    }
}
