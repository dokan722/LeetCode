using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3211 : IProblem
    {
        public bool Test()
        {
            var n = 3;

            var expected = 5;

            var result = ValidStrings(n);

            return expected == result.Count;
        }

        public IList<string> ValidStrings(int n)
        {
            var result = new List<string>();
            result.Add("0");
            result.Add("1");
            for (int i = 1; i < n; i++)
            {
                var newResult = new List<string>();
                foreach (var s in result)
                {
                    newResult.Add(s + "1");
                    if (s[^1]  == '1')
                        newResult.Add(s + "0");
                }

                result = newResult;
            }

            return result;
        }
    }
}
