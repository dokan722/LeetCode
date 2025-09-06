using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3495 : IProblem
    {
        public bool Test()
        {
            var queries = new[] { new[] { 1, 2 }, new[] { 2, 4 } };

            var expected = 3;

            var result = MinOperations(queries);

            Console.WriteLine(result);

            return expected == result;
        }

        public long MinOperations(int[][] queries)
        {
            long result = 0;

            foreach (var query in queries)
            {
                long left = query[0];
                long right = query[1];
                long begin = 1;
                long end = 1;
                long numOp = 0;
                long newOps = 0;
                while (left != 0)
                {
                    left /= 4;
                    begin *= 4;
                    numOp++;
                }

                while (right != 0)
                {
                    right /= 4;
                    end *= 4;
                }

                if (begin == end)
                {
                    result += ((query[1] - query[0] + 1) * numOp + 1) / 2;
                    continue;
                }

                newOps += numOp * (begin - query[0]);
                while (begin != end)
                {
                    numOp++;
                    long next = begin * 4;
                    newOps += (next - begin) * numOp;
                    begin = next;
                }
                newOps -= (end - query[1] - 1) * numOp;

                result += (newOps + 1) / 2;
            }

            return result;
        }
    }
}
