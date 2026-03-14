import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1288(Problem):
    def test(self) -> bool:
        intervals = [[1, 4], [3, 6], [2, 8]]

        expected = 2

        result = self.removeCoveredIntervals(intervals)

        print(result)

        return result == expected

    def removeCoveredIntervals(self, intervals: List[List[int]]) -> int:
        intervals.sort(key=lambda x: (x[0],-x[1]))
        end = -1
        result = 0
        for interval in intervals:
            if interval[1] > end:
                end = interval[1]
                result += 1

        return result