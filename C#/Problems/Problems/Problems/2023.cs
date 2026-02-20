using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2023 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { "777", "7", "77", "77" };
            var target = "7777";

            var expected = 4;

            var result = NumOfPairs(nums, target);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumOfPairs(string[] nums, string target)
        {
            var tl = target.Length;
            var result = 0;
            var parts = new Dictionary<string, int>();
            foreach (var num in nums)
            {
                var l = num.Length;
                if (l > tl)
                    continue;
                if (num == target.Substring(0, l))
                {
                    var suf = target.Substring(l, tl - l);
                    var sufs = parts.ContainsKey(suf) ? parts[suf] : 0;
                    result += sufs;
                }
                if (num == target.Substring(tl - l, l))
                {
                    var pref = target.Substring(0, tl - l);
                    var prefs = parts.ContainsKey(pref) ? parts[pref] : 0;
                    result += prefs;
                }
                if (parts.ContainsKey(num))
                    parts[num]++;
                else
                    parts[num] = 1;
            }

            return result;
        }
    }
}
