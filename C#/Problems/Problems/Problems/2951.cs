using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2951 : IProblem
    {
        public bool Test()
        {
            var mountain = new[] { 1, 4, 3, 8, 5 };

            var expected = new[] { 1, 3 };

            var result = FindPeaks(mountain);

            Utils.Print1DArray(result.ToArray());

            return Utils.Compare1DArrays(result.ToArray(), expected);
        }

        public IList<int> FindPeaks(int[] mountain)
        {
            var n = mountain.Length;
            var result = new List<int>();
            for (int i = 1; i < n - 1; ++i)
            {
                if (mountain[i] > mountain[i - 1] && mountain[i] > mountain[i + 1])
                    result.Add(i);
            }

            return result;
        }
    }
}
