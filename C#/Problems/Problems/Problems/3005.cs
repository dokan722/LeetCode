using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3005 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 2, 2, 3, 1, 4 };

            var expected = 4;

            var result = MaxFrequencyElements(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxFrequencyElements(int[] nums)
        {
            var freq = new Dictionary<int, int>();
            var maxFreq = 0;
            var result = 0;
            foreach (var num in nums)
            {
                if (freq.ContainsKey(num))
                    freq[num]++;
                else
                    freq[num] = 1;
                if (freq[num] > maxFreq)
                {
                    maxFreq = freq[num];
                    result = maxFreq;
                }
                else if (freq[num] == maxFreq)
                    result += maxFreq;
            }

            return result;
        }
    }
}
