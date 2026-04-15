using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1773 : IProblem
    {
        public bool Test()
        {
            var items = new[] {new[] {"phone", "blue", "pixel"}, new[] {"computer", "silver", "lenovo"}, new[] {"phone", "gold", "iphone"}};
            var ruleKey = "color";
            var ruleValue = "silver";

            var expected = 1;

            var result = CountMatches(items, ruleKey, ruleValue);

            Console.WriteLine(result);

            return result == expected;
        }

        public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue)
        {
            var result = 0;
            var rule = 0;
            if (ruleKey == "color")
                rule = 1;
            else if (ruleKey == "name")
                rule = 2;
            foreach (var item in items)
            {
                if (item[rule] == ruleValue)
                    result++;
            }
            return result;
        }
    }
}
