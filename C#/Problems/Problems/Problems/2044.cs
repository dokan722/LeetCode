using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2044 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 3, 2, 1, 5 };

            var expected = 6;

            var result = CountMaxOrSubsets(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int CountMaxOrSubsets(int[] nums)
        {
            var counts = new Dictionary<int, int>();

            TestSubset(0, 0, nums, counts);

            var result = 0;
            foreach (var value in counts.Values)
            {
                if (value > result)
                    result = value;
            }

            return result;
        }

        public void TestSubset(int num, int id, int[] nums, Dictionary<int, int> counts)
        {
            if (id >= nums.Length)
                return;
            TestSubset(num, id + 1, nums, counts);
            num = num | nums[id];
            if (!counts.ContainsKey(num))
                counts[num] = 1;
            else
                counts[num]++;
            TestSubset(num, id + 1, nums, counts);
        }
    }
}
