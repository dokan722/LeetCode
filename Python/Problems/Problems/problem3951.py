import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem3951(Problem):
    def test(self) -> bool:
        n = 5
        brightness = 5
        intervals = [[6, 12]]

        expected = 14

        result = self.minEnergy(n, brightness, intervals)

        print(result)

        return result == expected

    def minEnergy(self, n: int, brightness: int, intervals: list[list[int]]) -> int:
        cost = (brightness + 2) // 3
        intervals.sort(key=lambda i : (i[0], i[1]))
        result = 0
        th = 0
        for i in intervals:
            if th > i[1]:
                continue
            result += cost * (i[1] - max(i[0], th) + 1)
            th = i[1] + 1

        return result