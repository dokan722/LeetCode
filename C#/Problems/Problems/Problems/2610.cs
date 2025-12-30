using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2610 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 3, 4, 1, 2, 3, 1 };

            var expected = new[] { new[] { 1, 3, 4, 2 }, new[] { 1, 3 }, new[] { 1 } };

            var result = FindMatrix(nums).Select(x => x.ToArray()).ToArray();

            Utils.Print2DArray(result);

            return Utils.Compare2DArrays(expected, result);
        }

        public IList<IList<int>> FindMatrix(int[] nums)
        {
            var counts = new int[201];
            var result = new List<IList<int>>();
            foreach (var num in nums)
            {
                var row = counts[num];
                if (result.Count <= row)
                    result.Add(new List<int> { num });
                else
                    result[row].Add(num);
                counts[num]++;
            }

            return result;
        }
    }
}
