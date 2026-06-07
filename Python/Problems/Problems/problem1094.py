import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem1094(Problem):
    def test(self) -> bool:
        trips = [[2, 1, 5], [3, 3, 7]]
        capacity = 4

        expected = False

        result = self.carPooling(trips, capacity)

        return expected == result

    def carPooling(self, trips: List[List[int]], capacity: int) -> bool:
        sweep = [0] * 1002
        end = 0
        for t in trips:
            sweep[t[1]] += t[0]
            sweep[t[2]] -= t[0]
            end = max(end, t[2])
        cur = 0
        for i in range(end + 1):
            cur += sweep[i]
            if cur > capacity:
                return False

        return True
