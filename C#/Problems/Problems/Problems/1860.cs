using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1860 : IProblem
    {
        public bool Test()
        {
            var memory1 = 8;
            var memory2 = 11;

            var expected = new[] { 6, 0, 4 };

            var result = MemLeak(memory1, memory2);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(result, expected);
        }

        public int[] MemLeak(int memory1, int memory2)
        {
            var n = (long)memory1 + memory2 + 2;
            for (int i = 1; i < n; ++i)
            {
                if (memory1 >= memory2)
                {
                    if (memory1 < i)
                        return new[] { i, memory1, memory2 };
                    memory1 -= i;
                }
                else
                {
                    if (memory2 < i)
                        return new[] { i, memory1, memory2 };
                    memory2 -= i;
                }
            }

            return null;
        }
    }
}
