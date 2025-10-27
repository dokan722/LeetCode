using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2125 : IProblem
    {
        public bool Test()
        {
            var bank = new[] { "011001", "000000", "010100", "001000" };

            var expected = 8;

            var result = NumberOfBeams(bank);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumberOfBeams(string[] bank)
        {
            var last = 0;
            var result = 0;
            foreach (var row in bank)
            {
                var count = 0;
                foreach (var c in row)
                {
                    if (c == '1')
                        count++;
                }

                if (count > 0)
                {
                    result += last * count;
                    last = count;
                }
            }

            return result;
        }
    }
}
