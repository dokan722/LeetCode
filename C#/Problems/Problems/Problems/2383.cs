using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _2383 : IProblem
    {
        public bool Test()
        {
            var initialEnergy = 5;
            var initialExperience = 3;
            var energy = new[] {1, 4, 3, 2};
            var experience = new[] { 2, 6, 3, 1 };

            var expected = 8;

            var result = MinNumberOfHours(initialEnergy, initialExperience, energy, experience);

            Console.WriteLine(result);

            return expected == result;
        }

        public int MinNumberOfHours(int initialEnergy, int initialExperience, int[] energy, int[] experience)
        {
            var n = energy.Length;
            var expReq = experience[0] + 1;
            var curExp = expReq;
            var enReq = energy[0] + 1;
            for (int i = 1; i < n; ++i)
            {
                enReq += energy[i];
                curExp += experience[i - 1];
                var missing = experience[i] - curExp + 1;
                if (missing > 0)
                {
                    expReq += missing;
                    curExp += missing;
                }
            }

            return Math.Max(0, expReq - initialExperience) + Math.Max(0, enReq - initialEnergy);
        }
    }
}
