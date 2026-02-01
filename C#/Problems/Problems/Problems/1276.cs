using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1276 : IProblem
    {
        public bool Test()
        {
            var tomatoSlices = 4;
            var cheeseSlices = 17;

            var expected = new int[] { };

            var result = NumOfBurgers(tomatoSlices, cheeseSlices).ToArray();

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public IList<int> NumOfBurgers(int tomatoSlices, int cheeseSlices)
        {
            var doubleSlices = cheeseSlices * 2;
            var leftover = tomatoSlices - doubleSlices;
            if (doubleSlices > tomatoSlices || leftover % 2 == 1 || leftover > doubleSlices)
                return new int[] { };
            var jumbo = leftover / 2;
            return new[] { jumbo, cheeseSlices - jumbo };
        }
    }
}
