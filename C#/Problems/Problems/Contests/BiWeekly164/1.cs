using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems.Problems;

namespace Problems.Contests.BiWeekly164
{
    public class _1 : IProblem
    {
        public bool Test()
        {
            var n = 1553322;

            var expected = 1;

            var result = GetLeastFrequentDigit(n);
            
            Console.WriteLine(result);

            return result == expected;
        }

        public int GetLeastFrequentDigit(int n)
        {
            var count = new int[10];
            var num = n.ToString();
            foreach (var c in num)
                count[c - '0']++;

            var result = 0;
            var minCount = int.MaxValue;
            for (int i = 0; i < count.Length; ++i)
            {
                if (count[i] > 0 && count[i] < minCount)
                {
                    minCount = count[i];
                    result = i;
                }
            }

            return result;
        }
    }
}
