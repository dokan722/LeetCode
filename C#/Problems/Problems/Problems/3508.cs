using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Problems.Problems._3484;

namespace Problems.Problems
{
    public class _3508 : IProblem
    {
        public bool Test()
        {
            var router = new Router(3);
            if (!router.AddPacket(1, 4, 90))
                return false;
            if (!router.AddPacket(2, 5, 90))
                return false;
            if (router.AddPacket(1, 4, 90))
                return false;
            if (!router.AddPacket(3, 5, 95))
                return false;
            if (!router.AddPacket(4, 5, 105))
                return false;
            if (!router.ForwardPacket().SequenceEqual(new [] { 2, 5, 90 }))
                return false;
            if (!router.AddPacket(5, 2, 110))
                return false;
            if (router.GetCount(5, 100, 110) != 1)
                return false;

            return true;
        }

        public class Router
        {
            private readonly int _memorySize;
            private readonly Queue<(int Source, int Destination, int Timestamp)> _memory;
            private readonly HashSet<(int Source, int Destination, int Timestamp)> _presentPackages;
            private readonly Dictionary<int, List<int>> _destinations;

            public Router(int memoryLimit)
            {
                _memorySize = memoryLimit;
                _memory = new();
                _presentPackages = new();
                _destinations = new();
            }

            public bool AddPacket(int source, int destination, int timestamp)
            {
                if (_presentPackages.Contains((source, destination, timestamp)))
                    return false;
                if (_memory.Count >= _memorySize)
                {
                    var deq = _memory.Dequeue();
                    _presentPackages.Remove(deq);
                    _destinations[deq.Destination].RemoveAt(0);

                }
                _memory.Enqueue((source, destination, timestamp));
                _presentPackages.Add((source, destination, timestamp));
                if (!_destinations.ContainsKey(destination))
                    _destinations[destination] = new List<int>();
                _destinations[destination].Add(timestamp);
                return true;
            }

            public int[] ForwardPacket()
            {
                if (_memory.Count == 0)
                    return new int[]{};
                var deq = _memory.Dequeue();
                _presentPackages.Remove(deq);
                _destinations[deq.Destination].RemoveAt(0);
                return new[] { deq.Source, deq.Destination, deq.Timestamp };
            }

            public int GetCount(int destination, int startTime, int endTime)
            {
                if (endTime < startTime || !_destinations.ContainsKey(destination))
                    return 0;
                var list = _destinations[destination];
                return UpperBound(list, endTime) - LowerBound(list, startTime);
            }

            private int LowerBound(List<int> list, int value)
            {
                var left = 0;
                var right = list.Count;
                while (left < right)
                {
                    var mid = (left + right) / 2;
                    if (list[mid] < value)
                        left = mid + 1;
                    else
                        right = mid;
                }

                return left;
            }

            private int UpperBound(List<int> list, int value)
            {
                var left = 0;
                var right = list.Count;
                while (left < right)
                {
                    var mid = (left + right) / 2;
                    if (list[mid] <= value)
                        left = mid + 1;
                    else
                        right = mid;
                }

                return left;
            }
        }
    }
}
