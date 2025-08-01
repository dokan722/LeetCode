using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _898 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 1, 2, 4 };

            var expected = 6;

            var result = SubarrayBitwiseORs(arr);

            Console.WriteLine(result);

            return result == expected;
        }

        public int SubarrayBitwiseORs(int[] arr)
        {
            var result = new HashSet<int>();
            var partial = new HashSet<int>{0};
            foreach (var num in arr)
            {
                var tmp = new HashSet<int>();
                foreach (var prev in partial)
                    tmp.Add(num | prev);
                tmp.Add(num);
                foreach (var value in tmp)
                    result.Add(value);
                partial = tmp;
            }

            return result.Count;
        }
    }
}
