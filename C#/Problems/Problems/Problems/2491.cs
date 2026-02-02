using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2491 : IProblem
    {
        public bool Test()
        {
            var skill = new[] { 3, 2, 5, 1, 3, 4 };

            var expected = 22;

            var result = DividePlayers(skill);

            Console.WriteLine(result);

            return result == expected;
        }

        public long DividePlayers(int[] skill)
        {
            var n = skill.Length;
            long sum = 0;
            var skills = new Dictionary<int, int>();
            foreach (var s in skill)
            {
                if (skills.ContainsKey(s))
                    skills[s]++;
                else
                    skills[s] = 1;
                sum += s;
            }
            if (sum % (n / 2) != 0)
                return -1;
            int target = (int)(sum / (n / 2));
            long result = 0;
            foreach (var s in skill)
            {
                int req = target - s;
                if (!skills.ContainsKey(req) || skills[req] != skills[s])
                    return -1;
                result += s * req;
            }

            return result / 2;
        }
    }
}
