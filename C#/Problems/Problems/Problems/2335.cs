using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2335 : IProblem
    {
        public bool Test()
        {
            var amount = new int[] { 1, 4, 2 };

            var expected = 4;

            var result = FillCups(amount);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FillCups(int[] amount)
        {
            Array.Sort(amount);
            if (amount[2] > amount[0] + amount[1])
                return amount[2];

            var cut = amount[1] - amount[0];
            var rest = amount[0] - (amount[2] - cut) / 2;
            return rest + amount[2];
        }
    }
}
