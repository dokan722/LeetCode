import heapq
import math
import queue
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter, deque

from .problem import Problem

class Problem2029(Problem):
    def test(self) -> bool:
        stones = [2, 1]

        expected = True

        result = self.stoneGameIX(stones)

        return expected == result

    def stoneGameIX(self, stones: List[int]) -> bool:
        counts = [0, 0, 0]
        for stone in stones:
            counts[stone % 3] += 1

        if counts[0] % 2 == 0:
            return counts[1] >= 1 and counts[2] >= 1
        return abs(counts[1] - counts[2]) > 2