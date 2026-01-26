using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _119 : IProblem
    {
        public bool Test()
        {
            var rowIndex = 3;

            var expected = new[] { 1, 3, 3, 1 };

            var result = GetRow(rowIndex).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<int> GetRow(int rowIndex)
        {
            var result = new int[rowIndex + 1];
            result[0] = 1;
            result[rowIndex] = 1;
            for (int i = 1; i <= rowIndex; ++i)
            {
                var prev = result[0];
                for (int j = 1; j < rowIndex; ++j)
                {
                    var curr = result[j];
                    result[j] = prev + result[j];
                    prev = curr;
                }
            }
            return result;
        }
    }
}
