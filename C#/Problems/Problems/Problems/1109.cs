using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Problems
{
    public class _1109 : IProblem
    {
        public bool Test()
        {
            var bookings = new[] {new[] {1, 2, 10}, new[] {2, 3, 20}, new[] {2, 5, 25}};
            var n = 5;

            var expected = new[] { 10, 55, 45, 25, 25 };

            var result = CorpFlightBookings(bookings, n);

            Utils.Print1DArray(result);

            return Utils.Compare1DArrays(expected, result);
        }

        public int[] CorpFlightBookings(int[][] bookings, int n)
        {
            var sweepArray = new int[n + 1];
            foreach (var booking in bookings)
            {
                var first = booking[0] - 1;
                var last = booking[1] - 1;
                var seats = booking[2];
                sweepArray[first] += seats;
                sweepArray[last + 1] -= seats;
            }

            var result = new int[n];
            var curBooked = 0;
            for (int i = 0; i < n; ++i)
            {
                curBooked += sweepArray[i];
                result[i] = curBooked;
            }

            return result;
        }
    }
}
