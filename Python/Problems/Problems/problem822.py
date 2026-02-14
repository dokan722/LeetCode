import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem822(Problem):
    def test(self) -> bool:
        fronts = [1, 2, 4, 4, 7]
        backs = [1, 3, 4, 1, 3]

        expected = 2

        result = self.flipgame(fronts, backs)

        print(result)

        return result == expected

    def flipgame(self, fronts: List[int], backs: List[int]) -> int:
        n = len(fronts)
        maxVal = 2001
        present = [False] * maxVal
        impossible = [False] * maxVal
        for i in range(n):
            present[fronts[i]] = True
            present[backs[i]] = True
            if fronts[i] == backs[i]:
                impossible[fronts[i]] = True
        result = maxVal
        for i in range(1, maxVal):
            if present[i] and not impossible[i]:
                result = i
                break

        return 0 if result == maxVal else result