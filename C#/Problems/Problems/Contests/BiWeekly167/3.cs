using Problems.Problems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problems.Contests.BiWeekly167
{
    public class _3 : IProblem
    {
        public bool Test()
        {
            ExamTracker examTracker = new ExamTracker();

            examTracker.Record(1, 98);
            if (examTracker.TotalScore(1, 1) != 98)
                return false;
            examTracker.Record(5, 99);
            if (examTracker.TotalScore(1, 3) != 98)
                return false;
            if (examTracker.TotalScore(1, 5) != 197)
                return false;
            if (examTracker.TotalScore(3, 4) != 0)
                return false;
            if (examTracker.TotalScore(2, 5) != 99)
                return false;

            return true;
        }
        public class ExamTracker
        {
            private List<int> _times;
            private List<long> _sums;
            public ExamTracker()
            {
                _times = new() { 0 };
                _sums = new() { 0 };
            }

            public void Record(int time, int score)
            {
                _times.Add(time);
                _sums.Add(_sums[^1] + score);
            }

            public long TotalScore(int startTime, int endTime)
            {
                return _sums[SmallerOrEqual(endTime)] - _sums[BiggerOrEqual(startTime) - 1];
            }

            private int BiggerOrEqual(int t)
            {
                var left = 0;
                var right = _times.Count;
                while (left < right)
                {
                    var mid = (left + right) / 2;
                    if (_times[mid] >= t)
                        right = mid;
                    else
                        left = mid + 1;
                }

                return left;
            }

            private int SmallerOrEqual(int t)
            {
                var left = 0;
                var right = _times.Count - 1;
                while (left < right)
                {
                    var mid = (left + right + 1) / 2;
                    if (_times[mid] <= t)
                        left = mid;
                    else
                        right = mid - 1;
                }

                return left;
            }
        }
    }
}
