using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _415 : IProblem
    {
        public bool Test()
        {
            var num1 = "11";
            var num2 = "123";

            var expected = "134";

            var result = AddStrings(num1, num2);

            Console.WriteLine(result);

            return result == expected;
        }

        public string AddStrings(string num1, string num2)
        {
            var n = num1.Length;
            var m = num2.Length;
            var result = new StringBuilder();
            var l = Math.Max(num1.Length, num2.Length);
            var carry = 0;
            for (int i = 0; i < l; ++i)
            {
                var one = i < n ? num1[n - i - 1] - '0' : 0;
                var two = i < m ? num2[m - i - 1] - '0' : 0;
                var s = one + two + carry;
                var digit = s % 10;
                carry = s / 10;
                result.Insert(0, (char)(digit + '0'));
            }
            if (carry > 0)
                result.Insert(0, (char)(carry + '0'));
            return result.ToString();
        }
    }
}
