using System.Text;

namespace Problems.Problems
{
    public class _1061 : IProblem
    {
        public bool Test()
        {
            var s1 = "dfeffdfafbbebbebacbbdfcfdbcacdcbeeffdfebbdebbdafff";
            var s2 = "adcdfabadbeeafeabbadcefcaabdecabfecffbabbfcdfcaaae";
            var baseStr = "myickvflcpfyqievitqtwvfpsrxigauvlqdtqhpfugguwfcpqv";

            var expectedResult = "myiakvalapayqiavitqtwvapsrxigauvlqatqhpaugguwaapqv";

            var result = SmallestEquivalentString(s1, s2, baseStr);

            Console.WriteLine("Result: " + result);

            return result == expectedResult;
        }

        public string SmallestEquivalentString(string s1, string s2, string baseStr)
        {
            var bags = new List<HashSet<char>>();
            var coveredChars = new HashSet<char>();
            for (int i = 0; i < s1.Length; ++i)
            {
                if (s1[i] == s2[i])
                    continue;
                var contains1 = coveredChars.Contains(s1[i]);
                var contains2 = coveredChars.Contains(s2[i]);
                if (coveredChars.Count >= 26)
                    break;
                if (contains1)
                {
                    var bag = bags.FirstOrDefault(b => b.Contains(s1[i]));
                    bag.Add(s2[i]);
                    coveredChars.Add(s2[i]);
                }
                else if (contains2)
                {
                    var bag = bags.FirstOrDefault(b => b.Contains(s2[i]));
                    bag.Add(s1[i]);
                    coveredChars.Add(s1[i]);
                }
                else
                {
                    var newBag = new HashSet<char> { s1[i], s2[i] };
                    bags.Add(newBag);
                    coveredChars.Add(s1[i]);
                    coveredChars.Add(s2[i]);
                }
            }

            foreach(var c in coveredChars)
            {
                var multibag = bags.Where(bag => bag.Contains(c)).ToList();
                bags.RemoveAll(bags => multibag.Contains(bags));
                bags.Add(new HashSet<char>(multibag.SelectMany(b => b)));
            }

            var newString = new StringBuilder();



            foreach (var c in baseStr)
            {
                var bag = bags.FirstOrDefault(b => b.Contains(c));
                if (bag != null)
                {
                    newString.Append(bag.Min());
                }
                else
                {
                    newString.Append(c);
                }
            }

            return newString.ToString();
        }
    }
}
