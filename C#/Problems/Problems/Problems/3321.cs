using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _3321 : IProblem
    {
        public bool Test()
        {
            var nums = new[] { 1, 6, 5, 5, 5 };
            var k = 2;
            var x = 1;

            var expected = new long[] { 6, 10, 12 };

            var result = FindXSum(nums, k, x);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public long[] FindXSum(int[] nums, int k, int x)
        {
            var n = nums.Length;
            var counts = new Dictionary<long, int>();
            var smallSet = new SortedSet<(int, long)>();
            var bigSet = new SortedSet<(int, long)>();
            var result = new long[n - k + 1];
            long sum = 0;
            for (int i = 0; i < n; ++i)
            {
                if (i - k >= 0)
                {
                    result[i - k] = sum;
                    long toRemove = nums[i - k];
                    var p = (counts[toRemove], toRemove);
                    if (counts[toRemove] == 1)
                    {
                        counts.Remove(toRemove);
                        if (smallSet.Contains(p))
                            smallSet.Remove(p);
                        else
                        {
                            bigSet.Remove(p);
                            sum -= p.Item1 * p.Item2;
                            if (smallSet.Count > 0)
                            {
                                var biggest = smallSet.Max;
                                smallSet.Remove(biggest);
                                bigSet.Add(biggest);
                                sum += biggest.Item1 * biggest.Item2;
                            }
                        }
                    }
                    else
                    {
                        counts[toRemove]--;
                        var newP = (counts[toRemove], toRemove);
                        if (smallSet.Contains(p))
                        {
                            smallSet.Remove(p);
                            smallSet.Add(newP);
                        }
                        else
                        {
                            bigSet.Remove(p);
                            var biggest = smallSet.Max;
                            sum -= p.Item1 * p.Item2;
                            if (newP.CompareTo(biggest) < 0)
                            {
                                bigSet.Add(biggest);
                                smallSet.Remove(biggest);
                                smallSet.Add(newP);
                                sum += biggest.Item1 * biggest.Item2;
                            }
                            else
                            {
                                bigSet.Add(newP);
                                sum += newP.Item1 * newP.Item2;
                            }
                        }
                    }
                }
                long toAdd = nums[i];
                if (counts.ContainsKey(toAdd))
                {
                    var p = (counts[toAdd], toAdd);
                    counts[toAdd]++;
                    var newP = (counts[toAdd], toAdd);
                    if (bigSet.Contains(p))
                    {
                        bigSet.Remove(p);
                        bigSet.Add(newP);
                        sum += toAdd;
                    }
                    else
                    {
                        smallSet.Remove(p);
                        var smallest = bigSet.Min;
                        if (newP.CompareTo(smallest) > 0)
                        {
                            smallSet.Add(smallest);
                            bigSet.Remove(smallest);
                            bigSet.Add(newP);
                            sum -= smallest.Item1 * smallest.Item2;
                            sum += newP.Item1 * newP.Item2;
                        }
                        else
                            smallSet.Add(newP);

                    }
                }
                else
                {
                    counts[toAdd] = 1;
                    var newP = (counts[toAdd], toAdd);
                    if (bigSet.Count < x)
                    {
                        bigSet.Add(newP);
                        sum += toAdd;
                    }
                    else
                    {
                        var smallest = bigSet.Min;
                        if (newP.CompareTo(smallest) > 0)
                        {
                            smallSet.Add(smallest);
                            bigSet.Remove(smallest);
                            bigSet.Add(newP);
                            sum -= smallest.Item1 * smallest.Item2;
                            sum += newP.Item1 * newP.Item2;
                        }
                        else
                            smallSet.Add(newP);
                    }
                }

            }
            result[n - k] = sum;

            return result;
        }
    }
}
