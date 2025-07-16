using System.Numerics;

namespace Problems.Problems
{
    // SAME AS 2220
    public class _461 : IProblem
    {
        public bool Test()
        {
            var x = 1;
            var y = 4;

            var expected = 2;

            var result = HammingDistance(x, y);

            Console.WriteLine(result);

            return result == expected;
        }

        public int HammingDistance(int x, int y)
        {
            return BitOperations.PopCount((uint)x ^ (uint)y);
        }
    }
}
