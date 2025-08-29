using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3021 : IProblem
    {
        public bool Test()
        {
            var n = 3;
            var m = 2;

            var expected = 3;

            var result = FlowerGame(n, m);

            Console.WriteLine(result);

            return result == expected;
        }

        public long FlowerGame(int n, int m)
        {
            long nOdd = (n + 1) / 2;
            long nEven = n / 2;
            long mOdd = (m + 1) / 2;
            long mEven = m / 2;

            return nOdd * mEven + nEven * mOdd;
        }
    }
}
