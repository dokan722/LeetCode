import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1872(Problem):
    def test(self) -> bool:
        stones = [-1, 2, -3, 4, -5]

        expected = 5

        result = self.stoneGameVIII(stones)

        print(result)

        return result == expected

    def stoneGameVIII(self, stones: List[int]) -> int:
        n = len(stones)
        pref = [stones[0]]
        for i in range(1, n):
            pref.append(pref[i - 1] + stones[i])
        result = pref[n - 1]
        for i in range(n - 2, 0, -1):
            result = max(result, pref[i] - result)

        return result