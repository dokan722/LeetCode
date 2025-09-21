using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3274 : IProblem
    {
        public bool Test()
        {
            var coordinate1 = "a1";
            var coordinate2 = "c3";

            return CheckTwoChessboards(coordinate1, coordinate2);
        }

        public bool CheckTwoChessboards(string coordinate1, string coordinate2)
        {
            return (coordinate1[0] % 2 == coordinate1[1] % 2) == (coordinate2[0] % 2 == coordinate2[1] % 2);
        }
    }
}
