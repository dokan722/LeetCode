using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _781 : IProblem
    {
        public bool Test()
        {
            var answers = new[] { 1, 1, 2 };

            var expected = 5;

            var result = NumRabbits(answers);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumRabbits(int[] answers)
        {
            var result = 0;
            var added = new int[1002];
            foreach (var a in answers)
            {
                var act = a + 1;
                if (act == 1 || added[act] % act == 0)
                {
                    result += act;
                }
                added[act]++;
            }

            return result;
        }
    }
}
