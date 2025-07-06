using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1865 : IProblem
    {
        public bool Test()
        {
            FindSumPairs findSumPairs = new FindSumPairs(new[] {1, 1, 2, 2, 2, 3}, new[] {1, 4, 5, 2, 5, 4});
            var result = findSumPairs.Count(7);
            if (result != 8)
                return false;
            findSumPairs.Add(3, 2); 
            result = findSumPairs.Count(8);
            if (result != 2)
                return false;
            result = findSumPairs.Count(4);
            if (result != 1)
                return false;
            findSumPairs.Add(0, 1); 
            findSumPairs.Add(1, 1); 
            result = findSumPairs.Count(7);
            if (result != 11)
                return false;
            return true;
        }

        public class FindSumPairs
        {
            private int[] _nums1;
            private int[] _nums2;
            private Dictionary<int, int> _numsDic = new();

            public FindSumPairs(int[] nums1, int[] nums2)
            {
                _nums1 = nums1;
                _nums2 = nums2;
                for (int i = 0; i < nums2.Length; ++i)
                {
                    if (_numsDic.ContainsKey(nums2[i]))
                        _numsDic[nums2[i]] += 1;
                    else
                        _numsDic[nums2[i]] = 1;
                }
            }

            public void Add(int index, int val)
            {
                _numsDic[_nums2[index]] -= 1;
                _nums2[index] += val;
                if (_numsDic.ContainsKey(_nums2[index]))
                    _numsDic[_nums2[index]] += 1;
                else
                    _numsDic[_nums2[index]] = 1;
            }

            public int Count(int tot)
            {
                var result = 0;
                foreach (var val in _nums1)
                {
                    var com = tot - val;
                    if (_numsDic.TryGetValue(com, out var value))
                        result += value;
                }

                return result;
            }
        }
    }
}
