using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2582 : IProblem
    {
        public bool Test()
        {
            var n = 4;
            var time = 5;

            var expected = 2;

            var result = PassThePillow(n, time);

            Console.WriteLine(result);

            return result == expected;
        }

        public int PassThePillow(int n, int time)
        {
            var even = (time / (n - 1)) % 2 == 0;
            return even ? (time % (n - 1)) + 1 : n - (time % (n - 1));
        }
    }
}
