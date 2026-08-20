using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3069 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 2, 1, 3 };

            var expected = new[] { 2, 3, 1 };

            var result = ResultArray(nums);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] ResultArray(int[] nums)
        {
            var n = nums.Length;
            var nums1 = new Stack<int>();
            nums1.Push(nums[0]);
            var nums2 = new Stack<int>();
            nums2.Push(nums[1]);
            for (int i = 2; i < n; ++i)
            {
                if (nums1.Peek() > nums2.Peek())
                    nums1.Push(nums[i]);
                else
                    nums2.Push(nums[i]);
            }
            var result = new int[n];
            var k = n - 1;
            while (nums2.Count > 0)
                result[k--] = nums2.Pop();
            while (nums1.Count > 0)
                result[k--] = nums1.Pop();
            return result;
        }
    }
}
