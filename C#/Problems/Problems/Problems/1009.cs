using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1009 : IProblem
    {
        public bool Test()
        {
            var n = 10;

            var expected = 5;

            var result = BitwiseComplement(n);

            Console.WriteLine(result);

            return result == expected;
        }

        public int BitwiseComplement(int n)
        {
            if (n == 0)
                return 1;
            var result = 0;
            var len = 0;
            while (n > 0)
            {
                if (n % 2 == 0)
                {
                    result += 1 << len;
                }
                len++;
                n >>= 1;
            }
            return result;
        }   
    }
}
