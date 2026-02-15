using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _67 : IProblem
    {
        public bool Test()
        {
            var a = "1010";
            var b = "1011";

            var expected = "10101";

            var result = AddBinary(a, b);

            Console.WriteLine(result);

            return result == expected;
        }

        public string AddBinary(string a, string b)
        {
            var n = a.Length;
            var m = b.Length;
            var big = Math.Max(n, m);
            var result = new char[big + 1];
            var carry = 0;
            for (int i = 0; i <= big; ++i)
            {
                var first = i < n ? a[n - i - 1] - '0' : 0;
                var second = i < m ? b[m - i - 1] - '0' : 0;
                var total = carry + first + second;
                result[big - i] = (char)(total % 2 + '0');
                carry = total > 1 ? 1 : 0;
            }
            var resultStr = new string(result);
            return resultStr[0] == '0' ? resultStr.Substring(1) : resultStr;
        }
    }
}
