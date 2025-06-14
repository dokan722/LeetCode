using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _7 : IProblem
    {
        public bool Test()
        {
            var num = -123;

            var expected = -321;

            var result = Reverse(num);

            Console.WriteLine(result);

            return expected == result;
        }

        public int Reverse(int x)
        {
            var isNeg = x < 0;
            if (isNeg)
                x = -x;
            var num = new string(x.ToString().ToCharArray().Reverse().ToArray());
            if (isNeg)
                num = "-" + num;

            if (int.TryParse(num, out var result))
                return result;
            return 0;
        }
    }
}