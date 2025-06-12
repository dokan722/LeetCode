using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _9 : IProblem
    {
        public bool Test()
        {
            var n = 121;

            var expected = true;

            var result = IsPalindrome(n);

            Console.WriteLine(result);

            return expected == result;
        }

        public bool IsPalindrome(int x)
        {
            var num = x.ToString();
            var len = num.Length;

            return num.Substring(0, len / 2) == string.Join("",num.Substring(len - len/2, len/2).Reverse());
        }
    }
}
