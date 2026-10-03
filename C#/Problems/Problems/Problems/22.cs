using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _22 : IProblem
    {
        public bool Test()
        {
            var n = 3;

            var expected = new[] { "()()()", "()(())", "(())()", "(()())", "((()))" };

            var result = GenerateParenthesis(n);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<string> GenerateParenthesis(int n)
        {
            var result = new List<string>();
            var l = 2 * n;
            GenerateRec(result, "", 0, l);
            return result;
        }

        private void GenerateRec(List<string> result, string cur, int d, int l)
        {
            if (l - cur.Length < d)
                return;
            if (cur.Length == l)
            {
                result.Add(cur);
                return;
            }
            if (d != 0)
                GenerateRec(result, cur + ")", d - 1, l);
            GenerateRec(result, cur + "(", d + 1, l);
        }
    }
}
