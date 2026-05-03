using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _319 : IProblem
    {
        public bool Test()
        {
            var n = 3;

            var expected = 1;

            var result = BulbSwitch(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int BulbSwitch(int n)
        {
            return (int)Math.Sqrt(n);
        }
    }
}
