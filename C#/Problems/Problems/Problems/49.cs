using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _49 : IProblem
    {
        public bool Test()
        {
            var strs = new[] { "eat", "tea", "tan", "ate", "nat", "bat" };

            var expected = new[] { new[] { "eat", "tea", "ate" }, new[] { "tan", "nat" }, new[] { "bat" }};

            var result = GroupAnagrams(strs);

            Utils.Print2DArray(result.Select(x => x.ToArray()).ToArray());

            return Utils.Compare2DArrays(expected, result.Select(x => x.ToArray()).ToArray());
        }

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var result = new Dictionary<string, List<string>>();
            foreach (var s in strs)
            {
                var arr = s.ToCharArray();
                Array.Sort(arr);
                var key = string.Join("", arr);
                if (result.ContainsKey(key))
                    result[key].Add(s);
                else
                    result[key] = new List<string> { s };
            }

            return result.Values.Cast<IList<string>>().ToList();
        }
    }
}
