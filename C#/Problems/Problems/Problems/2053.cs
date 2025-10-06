using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2053 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { "d", "b", "c", "b", "c", "a" };
            var k = 2;

            var expected = "a";

            var result = KthDistinct(arr, k);

            Console.WriteLine(result);

            return expected == result;
        }

        public string KthDistinct(string[] arr, int k)
        {
            var present = new Dictionary<string, int>();
            foreach (var s in arr)
            {
                if (present.ContainsKey(s))
                    present[s]++;
                else
                    present.Add(s, 1);
            }
            var num = 0;
            foreach (var s in arr)
            {
                if (present[s] > 1)
                    continue;
                num++;
                if (num == k)
                    return s;
            }

            return "";
        }
    }
}
