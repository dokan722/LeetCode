using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3583 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 8, 4, 2, 8, 4 };

            var expected = 2;

            var result = SpecialTriplets(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int SpecialTriplets(int[] nums)
        {
            var countsAll = new Dictionary<int, int>();
            var countsCurr = new Dictionary<int, int>();
            var mod = 1000000007;
            foreach (var num in nums)
            {
                if (countsAll.ContainsKey(num))
                    countsAll[num]++;
                else
                {
                    countsAll[num] = 1;
                    countsCurr[num] = 0;
                }
            }

            long result = 0;
            foreach (var num in nums)
            {
                countsAll[num]--;
                var exp = 2 * num;
                if (countsAll.ContainsKey(exp)) 
                    result = (result + (long)countsAll[exp] * countsCurr[exp]) % mod;
                countsCurr[num]++;
            }

            return (int)result;
        }
    }
}
