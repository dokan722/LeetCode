using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public  class _3234 : IProblem
    {
        public bool Test()
        {
            var s = "00011";

            var expected = 5;

            var result = NumberOfSubstrings(s);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumberOfSubstrings(string s)
        {
            int n = s.Length;
            int[] ids = new int[n + 1];
            ids[0] = -1;
            for (int i = 0; i < n; i++)
            {
                if (i == 0 || s[i - 1] == '0')
                    ids[i + 1] = i;
                else
                    ids[i + 1] = ids[i];
            }
            int result = 0;
            for (int i = 1; i <= n; i++)
            {
                int zeros = s[i - 1] == '0' ? 1 : 0;
                int j = i;
                while (j > 0 && zeros * zeros <= n)
                {
                    int ones = (i - ids[j]) - zeros;
                    if (zeros * zeros <= ones)
                    {
                        result += Math.Min(j - ids[j], ones - zeros * zeros + 1);
                    }
                    j = ids[j];
                    zeros++;
                }
            }
            return result;
        }
    }
}
