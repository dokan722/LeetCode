using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3861 : IProblem
    {
        public bool Test()
        {
            var capacity = new[] {1, 5, 3, 7};
            var itemSize = 3;

            var expected = 2;

            var result = MinimumIndex(capacity, itemSize);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MinimumIndex(int[] capacity, int itemSize)
        {
            var n = capacity.Length;
            var minId = -1;
            for (int i = 0; i < n; ++i)
            {
                if (capacity[i] >= itemSize)
                {
                    minId = i;
                    break;
                }
            }
            if (minId == -1)
                return minId;
            for (int i = minId + 1; i < n; ++i)
            {
                if (capacity[i] >= itemSize && capacity[i] < capacity[minId])
                    minId = i;
            }

            return minId;
        }
    }
}
