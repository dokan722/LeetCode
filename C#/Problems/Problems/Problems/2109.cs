using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2109 : IProblem
    {
        public bool Test()
        {
            var s = "LeetcodeHelpsMeLearn";
            var spaces = new int[] { 8, 13, 15 };

            var expected = "Leetcode Helps Me Learn";

            var result = AddSpaces(s, spaces);

            Console.WriteLine(result);

            return result == expected;
        }


        public string AddSpaces(string s, int[] spaces)
        {
            int index = 0;
            var result = new StringBuilder();
            foreach (var space in spaces)
            {
                result.Append(s, index, space - index);
                result.Append(" ");
                index = space;
            }
            
            result.Append(s.Substring(index));
            return result.ToString();
        }
    }
}
