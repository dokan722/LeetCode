import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem

class Problem1011(Problem):
    def test(self) -> bool:
        weights = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
        days = 5

        expected = 15

        result = self.shipWithinDays(weights, days)

        print(result)

        return result == expected

    def shipWithinDays(self, weights: List[int], days: int) -> int:
        n = len(weights)
        l = 0
        r = 0
        for num in weights:
            l = max(num, l)
            r += num
        while l < r:
            mid = (l + r) // 2
            cur = 0
            for i in range(days):
                pack = 0
                while cur < n and pack + weights[cur] <= mid:
                    pack += weights[cur]
                    cur += 1
                if cur >= n:
                    break
            if cur >= n:
                r = mid
            else:
                l = mid + 1

        return l