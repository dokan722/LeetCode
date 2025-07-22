using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _258 : IProblem
    {
        public bool Test()
        {
            var num = 38;

            var expected = 2;

            var result = AddDigits(num);

            Console.WriteLine(result);

            return expected == result;
        }

        public int AddDigits(int num)
        {
            if (num == 0)
                return 0;
            return 1 + (num - 1) % 9;
        }
    }
}
