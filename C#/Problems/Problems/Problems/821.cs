using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _821 : IProblem
    {
        public bool Test()
        {
            var s = "loveleetcode";
            var c = 'e';

            var expected = new[] { 3, 2, 1, 0, 1, 0, 0, 1, 2, 2, 1, 0 };

            var result = ShortestToChar(s, c);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public int[] ShortestToChar(string s, char c)
        {
            var n = s.Length;
            var result = new int[n];
            var dist = n + 1;
            for (int i = 0; i < n; ++i)
            {
                if (s[i] == c)
                    dist = 0;
                else
                    dist++;
                result[i] = dist;
            }
            dist = n + 1;
            for (int i = n - 1; i >= 0; --i)
            {
                if (s[i] == c)
                    dist = 0;
                else
                    dist++;
                result[i] = Math.Min(result[i], dist);
            }

            return result;
        }
    }
}
