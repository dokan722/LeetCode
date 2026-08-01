using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3890 : IProblem
    {
        public bool Test()
        {
            var n = 4104;

            var expected = new[] { 1729, 4104 };

            var result = FindGoodIntegers(n);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<int> FindGoodIntegers(int n)
        {
            var root = (int)Math.Pow(n, 1.0 / 3);
            var present = new Dictionary<int, int>();
            var res = new List<int>();
            for (long i = 0; i <= root; ++i)
            {
                var sf = i * i * i;
                for (long j = i; j <= root; ++j)
                {
                    var sl = sf + j * j * j;
                    if (sl <= n)
                    {
                        var s = (int)sl;
                        if (present.ContainsKey(s) && present[s] == 1)
                        {
                            res.Add(s);
                            present[s]++;
                        }
                        else
                            present[s] = 1;
                    }
                    else
                        break;
                }
            }
            var result = res.OrderBy(x => x).ToArray();
            return result;
        }
    }
}
