using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1481 : IProblem
    {
        public bool Test()
        {
            var arr = new[] { 5, 5, 4 };
            var k = 1;

            var expected = 1;

            var result = FindLeastNumOfUniqueInts(arr, k);

            Console.WriteLine(result);

            return result == expected;
        }

        public int FindLeastNumOfUniqueInts(int[] arr, int k)
        {
            var counts = new Dictionary<int, int>();
            foreach (var num in arr)
            {
                if (counts.ContainsKey(num))
                    counts[num]++;
                else
                    counts[num] = 1;
            }
            var freq = counts.Values.ToArray();
            Array.Sort(freq);
            var end = 0;
            var m = freq.Length;
            while (end < m && k >= freq[end])
            {
                k -= freq[end];
                end++;
            }
            return m - end;
        }
    }
}
