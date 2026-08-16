
from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2187(Problem):
    def test(self) -> bool:
        time = [1, 2, 3]
        totalTrips = 5

        expected = 3

        result = self.minimumTime(time, totalTrips)

        print(result)

        return result == expected

    def minimumTime(self, time: List[int], totalTrips: int) -> int:
        left = 1
        right = time[0] * totalTrips
        while left < right:
            mid = (left + right) // 2
            total = 0
            for t in time:
                total += mid // t
            if total >= totalTrips:
                right = mid
            else:
                left = mid + 1
        return left