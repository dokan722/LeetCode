import heapq
import math
import sys

import numpy as np

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1642(Problem):
    def test(self) -> bool:
        heights = [4, 2, 7, 6, 9, 14, 12]
        bricks = 5
        ladders = 1

        expected = 4

        result = self.furthestBuilding(heights, bricks, ladders)

        print(result)

        return result == expected

    def furthestBuilding(self, heights: List[int], bricks: int, ladders: int) -> int:
        n = len(heights)
        used = []
        for i in range(1, n):
            diff = heights[i] - heights[i - 1]
            if diff <= 0:
                continue
            if ladders > 0:
                heapq.heappush(used, diff)
                ladders -= 1
            elif used and used[0] < diff:
                h = heapq.heappop(used)
                heapq.heappush(used, diff)
                bricks -= h
            else:
                bricks -= diff
            if bricks < 0:
                return i - 1

        return n - 1