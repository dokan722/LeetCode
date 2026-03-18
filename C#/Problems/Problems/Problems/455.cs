using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _455 : IProblem
    {
        public bool Test()
        {
            var g = new[] { 1, 2, 3 };
            var s = new[] { 1, 1 };

            var expected = 1;

            var result = FindContentChildren(g, s);

            Console.WriteLine(result);

            return result == expected;
        }
        public int FindContentChildren(int[] g, int[] s)
        {
            var n = g.Length;
            var m = s.Length;
            Array.Sort(g);
            Array.Sort(s);
            int i = 0;
            int j = 0;
            while (i < n && j < m)
            {
                if (g[i] <= s[j])
                {
                    i++;
                    j++;
                }
                else
                    j++;
            }

            return i;
        }
    }
}
