using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1894 : IProblem
    {
        public bool Test()
        {
            var chalk = new[] { 3, 4, 1, 2 };
            var k = 25;

            var expected = 1;

            var result = ChalkReplacer(chalk, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int ChalkReplacer(int[] chalk, int k)
        {
            long sum = 0;
            for (int i = 0; i < chalk.Length; i++)
                sum += chalk[i];
            long rest = k % sum;
            int child = 0;
            while (chalk[child] <= rest)
            {
                rest -= chalk[child];
                child++;
            }

            return child;
        }
    }
}
