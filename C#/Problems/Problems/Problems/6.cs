using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _6 : IProblem
    {
        public bool Test()
        {
            var s = "PAYPALISHIRING";
            var rows = 4;

            var expected = "PINALSIGYAHRPI";

            var result = Convert(s, rows);

            Console.WriteLine(result);

            return expected == result;
        }

        public string Convert(string s, int numRows)
        {
            if (numRows == 1)
                return s;

            var dist = numRows + Math.Max(0, numRows - 2);

            var result = new StringBuilder();
            for (int i = 0; i < s.Length; i +=  dist)
                result.Append(s[i]);

            for (int i = 1; i < numRows - 1; i++)
            {
                int j = i;
                for (; j < s.Length; j += dist)
                {
                    var prev = j - 2 * i;
                    if (prev > 0)
                        result.Append(s[prev]);
                    result.Append(s[j]);
                }
                var lastPrev = j - 2 * i;
                if (lastPrev > 0 && lastPrev < s.Length)
                    result.Append(s[lastPrev]);
            }

            for (int i = numRows - 1; i < s.Length; i += dist)
                result.Append(s[i]);


            return result.ToString();
        }
    }
}
