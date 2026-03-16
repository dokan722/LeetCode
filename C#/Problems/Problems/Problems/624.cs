using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _624 : IProblem
    {
        public bool Test()
        {
            var arrays = new[] { new[] { 1, 2, 3 }, new[] { 4, 5 }, new[] { 1, 2, 3 } };

            var expected = 4;

            var result = MaxDistance(arrays);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxDistance(IList<IList<int>> arrays)
        {
            var n = arrays.Count;
            int smallest = arrays[0][0];
            int biggest = arrays[0][arrays[0].Count - 1];
            int result = 0;
            for (int i = 1; i < n; ++i)
            {
                int curSmall = arrays[i][0];
                int curBig = arrays[i][arrays[i].Count - 1];
                result = Math.Max(result, Math.Abs(curBig - smallest));
                result = Math.Max(result, Math.Abs(biggest - curSmall));
                smallest = Math.Min(smallest, curSmall);
                biggest = Math.Max(biggest, curBig);

            }
            return result;
        }
    }
}
