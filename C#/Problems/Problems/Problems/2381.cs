using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2381 : IProblem
    {
        public bool Test()
        {
            var s = "abc";
            var shifts = new[] { new[] { 0, 1, 0 }, new[] { 1, 2, 1 }, new[] { 0, 2, 1 } };

            var expected = "ace";

            var result = ShiftingLetters(s, shifts);

            Console.WriteLine(result);

            return result == expected;
        }

        public string ShiftingLetters(string s, int[][] shifts)
        {
            var n = s.Length;
            var sweep = new int[n + 1];
            foreach (var shift in shifts)
            {
                var val = shift[2] == 1 ? 1 : -1;
                sweep[shift[0]] += val;
                sweep[shift[1] + 1] -= val;
            }

            var arr = s.ToCharArray();
            var cur = 0;
            for (int i = 0; i < n; ++i)
            {
                cur += sweep[i];
                arr[i] = (char)(((arr[i] - 'a' + cur) % 26 + 26) % 26 + 'a');
            }

            return new string(arr);
        }
    }
}
