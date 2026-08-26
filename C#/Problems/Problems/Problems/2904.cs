using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2904 : IProblem
    {
        public bool Test()
        {
            var s = "100011001";
            var k = 3;

            var expected = "11001";

            var result = ShortestBeautifulSubstring(s, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public string ShortestBeautifulSubstring(string s, int k)
        {
            var n = s.Length;
            var result = "";
            int i = 0;
            while (i < n && s[i] != '1')
                i++;
            if (i == n)
                return result;
            if (k == 1)
                return "1";
            var cur = 1;
            var last = i;
            for (i++; i < n; ++i)
            {
                if (s[i] == '1')
                {
                    if (cur < k)
                    {
                        cur++;
                    }
                    else
                    {
                        last++;
                        while (s[last] != '1')
                            last++;
                    }
                    if (cur == k)
                    {
                        var res = s.Substring(last, i - last + 1);
                        if (result == "" || result.Length > res.Length || (result.Length == res.Length && String.Compare(res, result) < 0))
                            result = res;
                    }
                }
            }

            return result;
        }
    }
}
