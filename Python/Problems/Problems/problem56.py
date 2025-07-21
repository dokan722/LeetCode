import sys
from typing import List

from .problem import Problem


class Problem56(Problem):
    def test(self) -> bool:
        intervals = [[1,3],[2,6],[8,10],[15,18]]

        expected = [[1,6],[8,10],[15,18]]

        result = self.merge(intervals)

        return expected == result

    def merge(self, intervals: List[List[int]]) -> List[List[int]]:
        maxLen = 10001
        overlaps = [0] * maxLen
        oneDays = [False] * maxLen
        first = sys.maxsize
        last = -sys.maxsize
        for interval in intervals:
            if interval[0] == interval[1]:
                oneDays[interval[0]] = True
            if interval[0] < first:
                first = interval[0]
            if interval[1] > last:
                last = interval[1]
            overlaps[interval[0]] += 1
            overlaps[interval[1]] -= 1

        result = []
        start = first
        runningSum = 0
        inside = overlaps[first] != 0
        for i in range(first, last + 1):
            runningSum += overlaps[i]
            if inside:
                if runningSum == 0:
                    result.append([start, i])
                    inside = False
            else:
                if runningSum != 0:
                    start = i
                    inside = True
            if runningSum == 0 and overlaps[i] == 0 and oneDays[i]:
             result.append([i, i])


        return result