using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _686 : IProblem
    {
        public bool Test()
        {
            var a = "abcd";
            var b = "cdabcdab";

            var expected = 3;

            var result = RepeatedStringMatch(a, b);

            Console.WriteLine(result);

            return result == expected;
        }

        public int RepeatedStringMatch(string a, string b)
        {
            var ai = 0;
            var al = a.Length;
            var bl = b.Length;
            while (ai < al && a[ai] != b[0])
                ai++;
            if (ai == al)
                return -1;
            var ass = ai;
            for (int bi = 0; bi < bl; ++bi)
            {
                if (a[ai % al] != b[bi])
                {
                    bi = 0;
                    ai = ass + 1;
                    while (a[ai % al] != b[0])
                        ai++;
                    if (ai > al)
                        return -1;
                    ass = ai;
                }
                ++ai;
            }

            return (ai + al - 1) / al;
        }
    }
}
