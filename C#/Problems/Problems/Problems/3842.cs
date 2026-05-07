using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3842 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 10, 30, 20, 10 };

            var expected = new[] { 20, 30 };

            var result = ToggleLightBulbs(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<int> ToggleLightBulbs(IList<int> bulbs)
        {
            var bb = new bool[101];
            foreach (var b in bulbs)
                bb[b] = !bb[b];
            var result = new List<int>();
            for (int i = 0; i <= 100; ++i)
                if (bb[i])
                    result.Add(i);
            return result;
        }
    }
}
