import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem849(Problem):
    def test(self) -> bool:
        seats = [1, 0, 0, 0, 1, 0, 1]

        expected = 2

        result = self.maxDistToClosest(seats)

        print(result)

        return result == expected

    def maxDistToClosest(self, seats: list[int]) -> int:
        n = len(seats)
        l = 0
        r = n - 1
        while seats[l] != 1:
            l += 1
        while seats[r] != 1:
            r -= 1
        result = max(l, n - 1 - r)
        if l != r:
            prev = l
            for i in range(l + 1, r + 1):
                if seats[i] == 1:
                    free = i - prev - 1
                    if free > 0:
                        result = max(result, (free - 1) // 2 + 1)
                    prev = i

        return result