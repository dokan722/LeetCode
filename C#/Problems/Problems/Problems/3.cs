using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3 : IProblem
    {
        public bool Test()
        {
            var s = "alouzxilkaxkufsu";

            var expected = 8;

            var result = LengthOfLongestSubstring(s);

            return expected == result;
        }

        public int LengthOfLongestSubstring(string s)
        {
            var partsDic = new Dictionary<char, int>();

            var longest = 0;
            var currLen = 0;
            for (int i = 0; i < s.Length; ++i)
            {
                currLen++;
                if (partsDic.TryGetValue(s[i], out var lastOcc))
                {
                    var dist = i - lastOcc;
                    if (dist <= currLen)
                    {
                        currLen = dist;
                    }
                    if (currLen > longest)
                        longest = currLen;
                }
                else
                {
                    if (currLen > longest)
                        longest = currLen;
                }
                partsDic[s[i]] = i;
            }

            if (currLen > longest)
                longest = currLen;

            return longest;
        }
    }
}
