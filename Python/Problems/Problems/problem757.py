import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set
from collections import Counter

from .problem import Problem


class Problem757(Problem):
    def test(self) -> bool:
        intervals = [[1, 3], [3, 7], [8, 9]]

        expected = 5

        result = self.intersectionSizeTwo(intervals)

        print(result)

        return expected == result

    def intersectionSizeTwo(self, intervals: List[List[int]]) -> int:
        intervals.sort(key=lambda x: (x[1], -x[0]))
        suf = [intervals[0][1] - 1, intervals[0][1]]
        result = 2
        for inter in intervals:
            start = inter[0]
            end = inter[1]
            if start <= suf[0]:
                continue
            if start > suf[1]:
                result += 2
                suf[0] = end - 1
                suf[1] = end
            else:
                result += 1
                suf[0] = suf[1]
                suf[1] = end

        return result