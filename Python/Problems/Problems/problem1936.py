import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1936(Problem):
    def test(self) -> bool:
        rungs = [1, 3, 5, 10]
        dist = 2

        expected = 2

        result = self.addRungs(rungs, dist)

        print(result)

        return expected == result

    def addRungs(self, rungs: List[int], dist: int) -> int:
        th = dist
        result = 0
        for rung in rungs:
            if rung > th:
                left = rung - th
                result += (left + dist - 1) // dist
            th = rung + dist

        return result