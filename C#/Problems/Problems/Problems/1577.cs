using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1577 : IProblem
    {
        public bool Test()
        {
            var nums1 = new[] { 7, 4 };
            var nums2 = new[] { 5, 2, 8, 9 };

            var expected = 1;

            var result = NumTriplets(nums1, nums2);

            Console.WriteLine(result);

            return expected == result;
        }

        public int NumTriplets(int[] nums1, int[] nums2)
        {
            var counts1 = new Dictionary<int, int>();
            var counts2 = new Dictionary<int, int>();
            var n1 = nums1.Length;
            var n2 = nums2.Length;
            for (int i = 0; i < n1; ++i)
            {
                if (counts1.ContainsKey(nums1[i]))
                        counts1[nums1[i]]++;
                else
                    counts1[nums1[i]] = 1;
            }

            for (int i = 0; i < n2; ++i)
            {
                if (counts2.ContainsKey(nums2[i]))
                    counts2[nums2[i]]++;
                else
                    counts2[nums2[i]] = 1;
            }

            var result = 0.0;

            for (int i = 0; i < n1; ++i)
            {
                var num = (long)nums1[i] * nums1[i];
                foreach (var key in counts2.Keys)
                {
                    if (num % key != 0)
                        continue;
                    var req = (int)(num / key);
                    if (counts2.ContainsKey(req))
                    {
                        if (req == key)
                            result += (counts2[key] * (counts2[req] - 1)) / 2;
                        else
                            result += (counts2[key] * counts2[req]) / 2.0;
                    }
                }
            }

            for (int i = 0; i < n2; ++i)
            {
                var num = (long)nums2[i] * nums2[i];
                foreach (var key in counts1.Keys)
                {
                    if (num % key != 0)
                        continue;
                    var req = (int)(num / key);
                    if (counts1.ContainsKey(req))
                    {
                        if (req == key)
                            result += (counts1[key] * (counts1[req] - 1)) / 2;
                        else
                            result += (counts1[key] * counts1[req]) / 2.0;
                    }
                }
            }

            return (int)result;
        }
    }
}
