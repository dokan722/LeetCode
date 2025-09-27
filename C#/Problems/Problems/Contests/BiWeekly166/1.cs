using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Problems.Problems;

namespace Problems.Contests.BiWeekly166
{
    public class _1 : IProblem
    {
        public bool Test()
        {
            var s = "aaabbbccdddde";

            var expected = "ab";

            var result = MajorityFrequencyGroup(s);

            Console.WriteLine(result);

            return expected == result;
        }

        public string MajorityFrequencyGroup(string s)
        {
            var counts = new int[26];
            foreach (var c in s)
                counts[c - 'a']++;

            var freqGrups = new Dictionary<int, List<char>>();
            for (int i = 0; i < 26; ++i)
            {
                if (freqGrups.ContainsKey(counts[i]))
                    freqGrups[counts[i]].Add((char)('a' + i));
                else
                    freqGrups[counts[i]] = new List<char> { (char)('a' + i)};
            }

            freqGrups.Remove(0);
            var maxGroupFreq = 0;
            var maxGroup = new List<char>();
            foreach (var freqGrup in freqGrups)
            {
                if (freqGrup.Value.Count > maxGroup.Count || (freqGrup.Value.Count == maxGroup.Count && freqGrup.Key > maxGroupFreq))
                {
                    maxGroup = freqGrup.Value;
                    maxGroupFreq = freqGrup.Key;
                }
            }

            return string.Join("", maxGroup);
        }
    }
}
