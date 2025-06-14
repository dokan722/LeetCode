using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _8 : IProblem
    {
        public bool Test()
        {
            var s = "   -42";

            var expected = -42;

            var result = MyAtoi(s);

            Console.WriteLine(result);

            return result == expected;
        }
        
        public int MyAtoi(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
            var i = 0;
            long result = 0;
            var isNeg = false;
            while (i < s.Length && char.IsWhiteSpace(s[i]))
                i++;
            if (i >= s.Length)
                return 0;
            if (s[i] == '-' || s[i] == '+')
            {
                isNeg = s[i] == '-';
                i++;
                if (i < s.Length && char.IsDigit(s[i]))
                {
                    result = s[i] - '0';
                    if (isNeg)
                        result *= -1;
                    i++;
                }
                else
                    return 0;
            }

            while (i < s.Length && char.IsDigit(s[i]))
            {
                result *= 10;
                if (isNeg)
                    result -= (s[i] - '0');
                else
                    result += (s[i] - '0');
                if (result is < 0 and < int.MinValue)
                {
                    return int.MinValue;
                }
                if (result > int.MaxValue)
                {
                    return int.MaxValue;
                }

                i++;
            }

            return (int)result;
        }
    }
}
