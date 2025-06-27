using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3371 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] {2, 3, 5, 10};

            var expected = 10;

            var result = GetLargestOutlier(nums);

            return expected == result;
        }

        public int GetLargestOutlier(int[] nums)
        {
            var sum = 0;
            var dic = new Dictionary<int, int>();
            foreach (var num in nums)
            {
                sum += num;
                if (dic.ContainsKey(num))
                    dic[num]++;
                else
                    dic[num] = 1;
            }
            var result = int.MinValue;
            foreach (var num in nums)
            {
                if ((sum - num) % 2 == 0 && dic.ContainsKey((sum - num) / 2) && ((sum - num) / 2 != num || dic[num] > 1))
                {
                    if (num > result)
                        result = num;
                }
            }

            return result;
        }
    }
}
