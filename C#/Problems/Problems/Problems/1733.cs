using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1733 : IProblem
    {
        public bool Test()
        {
            var n = 2;
            var languages = new[] { new[] { 1 }, new[] { 2 }, new[] { 1, 2 } };
            var friendships = new[] { new[] { 1, 2 }, new[] { 1, 3 }, new[] { 2, 3 } };

            var expected = 1;

            var result = MinimumTeachings(n, languages, friendships);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinimumTeachings(int n, int[][] languages, int[][] friendships)
        {
            var numPeople = languages.Length;
            var nonCommon = new HashSet<int>();
            var languagesSets = new HashSet<int>[numPeople];
            for (int i = 0; i < numPeople; ++i)
            {
                languagesSets[i] = new HashSet<int>(languages[i]);
            }
            foreach (var friendship in friendships)
            {
                if (IsCommonLanguage(languagesSets[friendship[0] - 1], languagesSets[friendship[1] - 1]))
                    continue;
                nonCommon.Add(friendship[0] - 1);
                nonCommon.Add(friendship[1] - 1);
            }
            
            var counts = new int[n];
            foreach (var non in nonCommon)
            {
                foreach (var language in languages[non])
                {
                    counts[language - 1]++;
                }
            }

            return nonCommon.Count - counts.Max();
        }

        private bool IsCommonLanguage(HashSet<int> languagesFirst, HashSet<int> languagesSecond)
        {
            foreach (var lang in languagesFirst)
            {
                if (languagesSecond.Contains(lang))
                    return true;
            }

            return false;
        }
    }
}
