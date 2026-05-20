using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _848 : IProblem
    {
        public bool Test()
        {
            var s = "abc";
            var shifts = new[] { 3, 5, 9 };

            var expected = "rpl";

            var result = ShiftingLetters(s, shifts);

            Console.WriteLine(result);

            return result == expected;
        }

        public string ShiftingLetters(string s, int[] shifts)
        {
            var n = s.Length;
            var arr = s.ToCharArray();
            long cur = 0;
            for (int i = n - 1; i >= 0; --i)
            {
                cur += shifts[i];
                arr[i] = (char)((arr[i] - 'a' + cur) % 26 + 'a');
            }
            return new string(arr);
        }
    }
}
