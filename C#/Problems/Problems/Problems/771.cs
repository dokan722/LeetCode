using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _771 : IProblem
    {
        public bool Test()
        {
            var jewels = "aA";
            var stones = "aAAbbbb";

            var expected = 3;

            var result = NumJewelsInStones(jewels, stones);

            Console.WriteLine(result);

            return result == expected;
        }

        public int NumJewelsInStones(string jewels, string stones)
        {
            var jewelsSet = new HashSet<char>();
            foreach (var jewel in jewels)
                jewelsSet.Add(jewel);
            var result = 0;
            foreach (var stone in stones)
                if (jewelsSet.Contains(stone))
                    result += 1;

            return result;
        }
    }
}
