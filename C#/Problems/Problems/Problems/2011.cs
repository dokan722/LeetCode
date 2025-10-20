using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2011 : IProblem
    {
        public bool Test()
        {
            var operations = new[] { "--X", "X++", "X++" };
            var expected = 1;

            var result = FinalValueAfterOperations(operations);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FinalValueAfterOperations(string[] operations)
        {
            var result = 0;
            foreach (var o in operations)
            {
                if (o == "X++" || o == "++X")
                    result++;
                else
                    result--;
            }

            return result;
        }
    }
}
