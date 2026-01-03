using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _838 : IProblem
    {
        public bool Test()
        {
            var dominoes = ".L.R...LR..L..";

            var expected = "LL.RR.LLRRLL..";

            var result = PushDominoes(dominoes);

            Console.WriteLine(result);

            return result == expected;
        }
        public string PushDominoes(string dominoes)
        {
            var n = dominoes.Length;
            var right = new int[n + 1];
            var left = new int[n + 1];
            for (int i = 1; i <= n; ++i)
            {
                if (dominoes[i - 1] == '.')
                    right[i] = Math.Max(0, right[i - 1] - 1);
                else if (dominoes[i - 1] == 'R')
                    right[i] = n;
                else
                    right[i] = 0;
            }
            for (int i = n - 1; i >= 0; --i)
            {
                if (dominoes[i] == '.')
                    left[i] = Math.Min(0, left[i + 1] + 1);
                else if (dominoes[i] == 'L')
                    left[i] = -n;
                else
                    left[i] = 0;
            }

            var result = new StringBuilder();
            for (int i = 0; i < n; ++i)
            {
                var val = right[i + 1] + left[i];
                if (val < 0)
                    result.Append('L');
                else if (val > 0)
                    result.Append('R');
                else
                    result.Append('.');
            }

            return result.ToString();
        }

    }
}
