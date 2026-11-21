using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3041 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 1, 5, 1, 1 };

            var expected = 3;

            var result = MaxSelectedElements(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public int MaxSelectedElements(int[] nums)
        {
            var n = nums.Length;
            if (n == 1)
                return 1;
            Array.Sort(nums);
            var result = 1;
            var cur = 1;
            var beg = 0;
            var rep = false;
            var sinceJump = 1;
            for (int i = 1; i < n; ++i)
            {
                if (nums[i] != nums[beg])
                {
                    if (nums[i] - nums[beg] == 1)
                    {
                        cur++;
                        sinceJump++;
                    }
                    else if (nums[i] - nums[beg] == 2)
                    {
                        if (rep)
                            cur += 2;
                        else
                        {
                            result = Math.Max(cur, result);
                            cur = 1 + sinceJump;
                        }
                        sinceJump = 1;
                        rep = false;
                    }
                    else
                    {
                        if (rep)
                            cur++;
                        result = Math.Max(cur, result);
                        cur = 1;
                        sinceJump = 1;
                        rep = false;
                    }
                    beg = i;
                }
                else
                    rep = true;
            }
            if (rep)
                cur++;
            result = Math.Max(cur, result);

            return result;
        }
    }
}
