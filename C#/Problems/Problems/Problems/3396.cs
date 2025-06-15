using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3396 : IProblem
    {
        public bool Test()
        {
            var nums = new int[] { 4, 5, 6, 4, 4 };


            var expected = 2;

            var result = MinimumOperations(nums);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinimumOperations(int[] nums)
        {
            var found = new bool[100];
            var i = nums.Length - 1;

            for (; i >= 0; i--)
            {
                if (found[nums[i] - 1])
                    break;
                
                found[nums[i] - 1] = true;
            }

            return (int)Math.Ceiling((i + 1) / 3.0);
        }

        
    }
}
