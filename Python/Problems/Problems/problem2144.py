import heapq
import math
import sys

from utils import print1DArray, print2DArray
from typing import List, Set, Optional
from collections import Counter

from .problem import Problem


class Problem2144(Problem):
    def test(self) -> bool:
        cost = [1, 2, 3]

        expected = 5

        result = self.minimumCost(cost)

        print(result)

        return result == expected

    def minimumCost(self, cost: List[int]) -> int:
        n = len(cost)
        cost.sort()
        free = n % 3
        result = 0
        for i in range(n):
            if i % 3 != free:
                result += cost[i]

        return result