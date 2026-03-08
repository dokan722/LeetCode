using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1980 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { "111", "011", "001" };

            var expected = "000";

            var result = FindDifferentBinaryString(nums);

            Console.WriteLine(result);

            return result == expected;
        }

        public string FindDifferentBinaryString(string[] nums)
        {
            var n = nums.Length;
            string result = "";
            for (int i = 0; i < n; ++i)
            {
                result += nums[i][i] == '0' ? '1' : '0';
            }

            return result;
        }
    }
}
